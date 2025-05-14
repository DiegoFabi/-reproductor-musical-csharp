using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using static LibClases.Controlador;
using System.Speech.Recognition;
using LibClases;

namespace SoftSound
{
    public partial class SoftSound : Form
    {
        private ReproductorVoz voz;
        private ReproductorMusical reproductor;
        private int indiceActual = 0;
        private List<Cancion> ListaCanciones { get { return ReproductorMusical.ListaCanciones; } }

        public SoftSound()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            this.Load += new EventHandler(SoftSound_Load);
            voz = new ReproductorVoz();
            voz.ComandoReconocido += new Action<string>(ProcesarVoz);
            voz.IniciarReconocimiento();

            axWindowsMediaPlayer1.settings.volume = 50;
            tbVolumen.Value = 50;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            reproductor = new ReproductorMusical();
        }

        private void SoftSound_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(AxWindowsMediaPlayer1_PlayStateChange);
        }

        private void ProcesarVoz(string comando)
        {
            if (comando == "play" || comando == "pause" || comando == "parar")
                btnPlayStop_Click(this, EventArgs.Empty);
            else if (comando == "stop")
                btnDetener_Click(this, EventArgs.Empty);
            else if (comando == "next" || comando == "siguiente")
                btnSig_Click(this, EventArgs.Empty);
            else if (comando == "previous" || comando == "anterior")
                btnAnt_Click(this, EventArgs.Empty);
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlayStop.Values.Image = Properties.Resources.Play;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlayStop.Values.Image = Properties.Resources.Pausar;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.Count == 0) return;
            indiceActual = (indiceActual - 1 + ListaCanciones.Count) % ListaCanciones.Count;
            ActualizarInterfaz();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.Count == 0) return;
            indiceActual = (indiceActual + 1) % ListaCanciones.Count;
            ActualizarInterfaz();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            btnPlayStop.Values.Image = Properties.Resources.Play;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            if (!Directory.Exists(rutaDirectorio))
            {
                MessageBox.Show("La carpeta Musica no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarDirectorio(rutaDirectorio);
            if (ListaCanciones.Count > 0)
            {
                indiceActual = 0;
                ActualizarInterfaz();
            }
            else
            {
                MessageBox.Show("No hay canciones en la carpeta de música.", "Carpeta vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de audio (*.mp3;*.wav;*.wma)|*.mp3;*.wav;*.wma";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Selecciona archivos de audio";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Cancion> nuevasCanciones = new List<Cancion>();

                foreach (string ruta in openFileDialog.FileNames)
                {
                    if (File.Exists(ruta) && !ListaCanciones.Any(c => c.ruta == ruta))
                    {
                        Cancion cancion = new Cancion();
                        cancion.nombre = Path.GetFileNameWithoutExtension(ruta);
                        cancion.ruta = ruta;
                        nuevasCanciones.Add(cancion);
                    }
                }

                if (nuevasCanciones.Count > 0)
                {
                    reproductor.AgregarCanciones(nuevasCanciones);

                    if (ListaCanciones.Count == nuevasCanciones.Count)
                    {
                        indiceActual = 0;
                        ActualizarInterfaz();
                    }
                }
                else
                {
                    MessageBox.Show("Los archivos ya estaban en la lista o no son válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CargarDirectorio(string directorio)
        {
            string[] rutas = Directory.GetFiles(directorio, "*.*", SearchOption.TopDirectoryOnly);

            List<Cancion> nuevasCanciones = new List<Cancion>();

            foreach (string ruta in rutas)
            {
                if ((ruta.EndsWith(".mp3") || ruta.EndsWith(".wav") || ruta.EndsWith(".wma")) && !ListaCanciones.Any(c => c.ruta == ruta))
                {
                    Cancion c = new Cancion();
                    c.nombre = Path.GetFileNameWithoutExtension(ruta);
                    c.ruta = ruta;
                    nuevasCanciones.Add(c);
                }
            }

            reproductor.AgregarCanciones(nuevasCanciones);
        }

        private void ActualizarInterfaz()
        {
            if (ListaCanciones.Count == 0 || indiceActual < 0 || indiceActual >= ListaCanciones.Count) return;

            Cancion cancion = ListaCanciones[indiceActual];
            axWindowsMediaPlayer1.URL = cancion.ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            lblNombre.Text = cancion.nombre;
            tbDuracion.Value = 0;
            lblTime.Text = "00:00";
            timer.Start();
            btnPlayStop.Values.Image = Properties.Resources.Pausar;
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                this.BeginInvoke(new MethodInvoker(delegate {
                    ReproducirSiguienteCancion();
                }));
            }
        }

        private void ReproducirSiguienteCancion()
        {
            if (ListaCanciones.Count == 0) return;

            indiceActual = (indiceActual + 1) % ListaCanciones.Count;
            ActualizarInterfaz();
        }

        private void tbDuracion_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = tbDuracion.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying && axWindowsMediaPlayer1.currentMedia != null)
            {
                int duracion = (int)axWindowsMediaPlayer1.currentMedia.duration;
                int posicionActual = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                tbDuracion.Maximum = duracion;
                tbDuracion.Value = Math.Min(posicionActual, tbDuracion.Maximum);
                lblTime.Text = string.Format("{0} / {1}", FormatearTiempo(posicionActual), FormatearTiempo(duracion));
            }
        }

        private string FormatearTiempo(int segundos)
        {
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;
            return string.Format("{0:D2}:{1:D2}", minutos, segundosRestantes);
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            bool estaMuteado = axWindowsMediaPlayer1.settings.volume == 0;
            axWindowsMediaPlayer1.settings.volume = estaMuteado ? 100 : 0;
            btnVolumen.Values.Image = estaMuteado ? Properties.Resources.Volumen : Properties.Resources.MuteAll;
        }

        private void tbVolumen_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = tbVolumen.Value;
            btnVolumen.Values.Image = tbVolumen.Value == 0 ? Properties.Resources.Mute : Properties.Resources.Volumen;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer.Stop();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
