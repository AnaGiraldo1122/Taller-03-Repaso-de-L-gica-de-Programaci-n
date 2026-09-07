using System;

namespace movCaballos
{
 public class Caballos
    {


        private static string[,] ajedrez = new string[8, 8];



        public void PosCabInTabAjedrez(string[] PosCab)
        {
            foreach (string cab in PosCab)
            {      
                int columna = cab[0] - 'A';
                int fila = 8 - (cab[1] - '0');

                if (fila >= 0 && fila < 8 && columna >= 0 && columna < 8)
                {
                    ajedrez[fila, columna] = cab; 
                }

            }

        }
        public string[] MovimientInL(string PosCab)
        {
            string[] posMov = new string[8];

            int[] DesplazamientoFilas = { 2, 2, -2, -2, 1, 1, -1, -1 };
            int[] DesplazamientoColumnas = { 1, -1, 1, -1, 2, -2, 2, -2 };
            int ContPos = 0;
            int columna = PosCab[0] - 'A';
            int fila = 8 - (PosCab[1] - '0');

            for (int i = 0; i < 8; i++)
            {
                int nuevaFila = fila + DesplazamientoFilas[i];
                int nuevaColumna = columna + DesplazamientoColumnas[i];

                if (nuevaFila >= 0 && nuevaFila < 8 && nuevaColumna >= 0 && nuevaColumna < 8)
                {

                    posMov[ContPos] = ConvertirAColumnaFilaAjedrez(nuevaFila, nuevaColumna);
                    ContPos += 1;

                }

            }

            return posMov;
        }

        public string ConvertirAColumnaFilaAjedrez(int fila, int columna)
        {
            if (fila < 0 || fila > 7 || columna < 0 || columna > 7)
            {
                return "";
            }
            char letra = (char)('A' + columna);
            int numeroFila = 8 - fila;

            return $"{letra}{numeroFila}";

        }



    }
}
