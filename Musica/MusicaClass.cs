

namespace ContenidoMusical
{
    public class Musica
    {
        #region Atributos
        private string nomcancion;
        private string genero;
        private string album;
        private string artista;
        private ushort duracion;
        private ushort año;
        #endregion

        #region Propiedades
        public string Nomcancion { get => nomcancion; set => nomcancion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Album { get => album; set => album = value; }
        public string Artista { get => artista; set => artista = value; }
        public ushort Duracion { get => duracion; set => duracion = value; }
        public ushort Año { get => año; set => año = value; }
        #endregion

        #region Constructor
        public Musica(string nomcancion, string genero, string album, string artista, ushort duracion, ushort año)
        {
            Nomcancion = nomcancion;
            Genero = genero;
            Album = album;
            Artista = artista;
            Duracion = duracion;
            Año = año;
        }
        #endregion

    }
}
