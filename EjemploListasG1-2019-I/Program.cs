using System;
using System.Collections.Generic;
using ContenidoMusical;
namespace EjemploListasG1_2019_I
{
    class Program
    {
        static void Main()
        {
            

            

            List<Musica > milistamusical = new List<Musica>();

            Musica mimusica = new Musica("Mátalas","Ranchera","Compilación Regional","Alejandro Fernandez",180,2003);
            Musica cancion2 = new Musica("Lo que no fue no será", "Balada", "Sinfónico", "El principe de la canción", 225, 2018);
            Musica cancion3 = new Musica("El sinaloense", "Banda", "Grandes hits", "Banda El recodo", 134, 2000);


            milistamusical.Add(mimusica);
            milistamusical.Add(cancion2);
            milistamusical.Add(cancion3);

            Console.WriteLine("Album " + milistamusical[0].Album);

            Console.WriteLine("¿Qué canción te gustaría escuchar? :D");
            string aux= Console.ReadLine();

            for(int i=0; i<milistamusical.Count; i++)
            {
                if (milistamusical[i].Nomcancion==aux)
                {
                    Console.WriteLine("Reproduciendo " + milistamusical[i].Nomcancion + " del álbum " + milistamusical[i].Album + " del artista " + milistamusical[i].Artista + " con duración de " + milistamusical[i].Duracion + " segundos " + " del año " + milistamusical[i].Año);

                }

            }


            Console.WriteLine("¿Qué canción te gustaría eliminar ?");
            aux = Console.ReadLine();

            for (int i = 0; i < milistamusical.Count; i++)
            {
                if (milistamusical[i].Nomcancion == aux)
                {
                    milistamusical.RemoveAt(i);
                }

            }

            for (int i = 0; i < milistamusical.Count; i++)
            {
                Console.WriteLine("Nombre" + milistamusical[i].Nomcancion + " del álbum " + milistamusical[i].Album + " del artista " + milistamusical[i].Artista + " con duración de " + milistamusical[i].Duracion + " segundos " + " del año " + milistamusical[i].Año);
            }






        }
    }
}
