using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Clases.ArchivoPlano
{
    class ClsArchivo
    {
        public string[,] LeerArchivo()
        {
            string[] ArregloNombres = File.ReadAllLines(@"C:\Users\alumno\Desktop\C# Arreglos\archivoPlano.csv",Encoding.Default);

            int acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNombres.Length, 5];

            foreach (string linea in ArregloNombres)
            {
                string[] datos = linea.Split(';');

                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                acumulador++;

            }

            return ArregloDosDimensiones;


        }

    }
}
