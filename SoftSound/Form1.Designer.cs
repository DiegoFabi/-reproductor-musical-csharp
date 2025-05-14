namespace SoftSound
{
    partial class SoftSound
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftSound));
            this.btnPlayStop = new Krypton.Toolkit.KryptonButton();
            this.btnSig = new Krypton.Toolkit.KryptonButton();
            this.btnAnt = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArchivos = new Krypton.Toolkit.KryptonButton();
            this.btnVolumen = new Krypton.Toolkit.KryptonButton();
            this.tbVolumen = new XComponent.SliderBar.MACTrackBar();
            this.btnDetener = new Krypton.Toolkit.KryptonButton();
            this.btnAddAll = new Krypton.Toolkit.KryptonButton();
            this.tbDuracion = new XComponent.SliderBar.MACTrackBar();
            this.lblNombre = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSalir = new Krypton.Toolkit.KryptonButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnPlayStop.Location = new System.Drawing.Point(400, 34);
            this.btnPlayStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(37, 36);
            this.btnPlayStop.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StatePressed.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.btnPlayStop.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnPlayStop.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnPlayStop.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnPlayStop.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPlayStop.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnPlayStop.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.True;
            this.btnPlayStop.TabIndex = 0;
            this.btnPlayStop.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPlayStop.Values.Image = global::SoftSound.Properties.Resources.Play;
            this.btnPlayStop.Values.ImageStates.ImageCheckedNormal = null;
            this.btnPlayStop.Values.ImageStates.ImageCheckedPressed = null;
            this.btnPlayStop.Values.ImageStates.ImageCheckedTracking = null;
            this.btnPlayStop.Values.ImageStates.ImageDisabled = global::SoftSound.Properties.Resources.Pausar;
            this.btnPlayStop.Values.Text = "";
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // btnSig
            // 
            this.btnSig.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSig.Location = new System.Drawing.Point(480, 39);
            this.btnSig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(27, 26);
            this.btnSig.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnSig.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnSig.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnSig.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnSig.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnSig.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnSig.TabIndex = 1;
            this.btnSig.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSig.Values.Image = global::SoftSound.Properties.Resources.Siguiente;
            this.btnSig.Values.Text = "";
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAnt.Location = new System.Drawing.Point(320, 39);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(27, 26);
            this.btnAnt.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnAnt.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnAnt.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnAnt.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnAnt.TabIndex = 2;
            this.btnAnt.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAnt.Values.Image = global::SoftSound.Properties.Resources.Anterior;
            this.btnAnt.Values.Text = "";
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnArchivos);
            this.panel1.Controls.Add(this.btnVolumen);
            this.panel1.Controls.Add(this.tbVolumen);
            this.panel1.Controls.Add(this.btnDetener);
            this.panel1.Controls.Add(this.btnPlayStop);
            this.panel1.Controls.Add(this.btnSig);
            this.panel1.Controls.Add(this.btnAnt);
            this.panel1.Location = new System.Drawing.Point(12, 390);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 101);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnArchivos
            // 
            this.btnArchivos.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnArchivos.Location = new System.Drawing.Point(17, 34);
            this.btnArchivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(29, 30);
            this.btnArchivos.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnArchivos.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnArchivos.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnArchivos.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnArchivos.TabIndex = 10;
            this.btnArchivos.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnArchivos.Values.Image = global::SoftSound.Properties.Resources.Folder;
            this.btnArchivos.Values.Text = "Agregar Todo";
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnVolumen.Location = new System.Drawing.Point(593, 41);
            this.btnVolumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(24, 26);
            this.btnVolumen.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnVolumen.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnVolumen.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnVolumen.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnVolumen.TabIndex = 7;
            this.btnVolumen.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVolumen.Values.Image = global::SoftSound.Properties.Resources.Volumen;
            this.btnVolumen.Values.Text = "";
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // tbVolumen
            // 
            this.tbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.tbVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.tbVolumen.IndentHeight = 6;
            this.tbVolumen.Location = new System.Drawing.Point(636, 39);
            this.tbVolumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVolumen.Maximum = 100;
            this.tbVolumen.Minimum = 0;
            this.tbVolumen.Name = "tbVolumen";
            this.tbVolumen.Size = new System.Drawing.Size(219, 22);
            this.tbVolumen.TabIndex = 6;
            this.tbVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.tbVolumen.TickHeight = 4;
            this.tbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.tbVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.tbVolumen.TrackLineHeight = 3;
            this.tbVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.tbVolumen.Value = 0;
            this.tbVolumen.Scroll += new System.EventHandler(this.tbVolumen_Scroll);
            // 
            // btnDetener
            // 
            this.btnDetener.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnDetener.Location = new System.Drawing.Point(261, 39);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(27, 26);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDetener.Values.Image = global::SoftSound.Properties.Resources.Detener;
            this.btnDetener.Values.Text = "";
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAddAll.Location = new System.Drawing.Point(29, 18);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(29, 30);
            this.btnAddAll.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnAddAll.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnAddAll.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnAddAll.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.ToolTipValues.Description = "Esto agrega toda la musica que tienes en tu carpeta Musica por default";
            this.btnAddAll.ToolTipValues.EnableToolTips = true;
            this.btnAddAll.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddAll.Values.Image = global::SoftSound.Properties.Resources.UploadAll;
            this.btnAddAll.Values.Text = "";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // tbDuracion
            // 
            this.tbDuracion.BackColor = System.Drawing.Color.Transparent;
            this.tbDuracion.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDuracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.tbDuracion.IndentHeight = 6;
            this.tbDuracion.Location = new System.Drawing.Point(17, 345);
            this.tbDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDuracion.Maximum = 10;
            this.tbDuracion.Minimum = 0;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(852, 24);
            this.tbDuracion.TabIndex = 5;
            this.tbDuracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDuracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.tbDuracion.TickHeight = 4;
            this.tbDuracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDuracion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbDuracion.TrackerSize = new System.Drawing.Size(12, 12);
            this.tbDuracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.tbDuracion.TrackLineHeight = 3;
            this.tbDuracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.tbDuracion.Value = 0;
            this.tbDuracion.Scroll += new System.EventHandler(this.tbDuracion_Scroll);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(20, 290);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(354, 46);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Reproduce Musica";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(25, 258);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00";
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSalir.Location = new System.Drawing.Point(841, 18);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 26);
            this.btnSalir.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btnSalir.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btnSalir.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.btnSalir.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalir.Values.Image = global::SoftSound.Properties.Resources.Switch;
            this.btnSalir.Values.Text = "";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 26);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cargar Todo";
            // 
            // SoftSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SoftSound";
            this.Text = "SoftSound";
            this.Load += new System.EventHandler(this.SoftSound_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnPlayStop;
        private Krypton.Toolkit.KryptonButton btnSig;
        private Krypton.Toolkit.KryptonButton btnAnt;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnDetener;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Krypton.Toolkit.KryptonButton btnAddAll;
        private XComponent.SliderBar.MACTrackBar tbVolumen;
        private XComponent.SliderBar.MACTrackBar tbDuracion;
        private Krypton.Toolkit.KryptonButton btnVolumen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private Krypton.Toolkit.KryptonButton btnSalir;
        private Krypton.Toolkit.KryptonButton btnArchivos;
        private System.Windows.Forms.Label label1;
    }
}

