using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lucky.CFG.Util
{
    public class FileCSV
    {
        public void crearArchivo(string nombre,string contenido)
        {            
            StreamWriter sw = new StreamWriter(nombre, false);
            
            sw.WriteLine(contenido);
            sw.Close();            
        }

    }
}
