using System;
using System.IO;

namespace TPWinForm_equipo_2A
{
    public static class ImagenesHelper
    {
        public static string ObtenerCarpetaImagenes()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "TPWinForm_equipo_2A",
                "ImagenesProductos"
            );
        }

        public static string ObtenerRutaCompleta(string nombreArchivo)
        {
            if (string.IsNullOrWhiteSpace(nombreArchivo))
                return string.Empty;

            if (Path.IsPathRooted(nombreArchivo))
                return nombreArchivo;

            return Path.Combine(ObtenerCarpetaImagenes(), nombreArchivo);
        }
    }
}
