using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Controlador
    {
        public class ReproductorMusical
        {
            public static List<Cancion> ListaCanciones { get; private set; } = new List<Cancion>();
            public int IndiceActual { get; private set; } = 0;

            public Cancion CancionActual => ListaCanciones.Count > 0 ? ListaCanciones[IndiceActual] : null;

            public void AgregarCancion(Cancion c)
            {
                if (!ListaCanciones.Any(x => x.ruta == c.ruta))
                    ListaCanciones.Add(c);
            }

            public void AgregarCanciones(IEnumerable<Cancion> canciones)
            {
                foreach (var c in canciones)
                    AgregarCancion(c);
            }

            public void Reiniciar()
            {
                IndiceActual = 0;
            }

            // Métodos para controlar la reproducción, pueden ser llamados desde el reconocimiento de voz.
            public void Play()
            {
                if (ListaCanciones.Count > 0)
                {
                    Console.WriteLine($"Reproduciendo: {CancionActual.nombre}");
                    
                }
            }

            public void Pause()
            {
                if (ListaCanciones.Count > 0)
                {
                    Console.WriteLine($"Pausado: {CancionActual.nombre}");
                    // Lógica para pausar el audio.
                }
            }

            public void Stop()
            {
                if (ListaCanciones.Count > 0)
                {
                    Console.WriteLine("Reproducción detenida");
                    // Lógica para detener la reproducción.
                }
            }

            public void Next()
            {
                if (IndiceActual < ListaCanciones.Count - 1)
                {
                    IndiceActual++;
                    Console.WriteLine($"Siguiente: {CancionActual.nombre}");
                    // Lógica para cambiar a la siguiente canción.
                }
            }

            public void Previous()
            {
                if (IndiceActual > 0)
                {
                    IndiceActual--;
                    Console.WriteLine($"Anterior: {CancionActual.nombre}");
                    // Lógica para volver a la canción anterior.
                }
            }
        }
    }
}
