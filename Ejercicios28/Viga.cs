namespace Ejercicio28
{
    public class Viga
    {
        private string estructura;

        public Viga(string estructura)
        {
            this.estructura = estructura;
        }

        private int ObtenerResistencia()
        {
            if (estructura[0] == '%')
            {
                return 10;
            }

            if (estructura[0] == '&')
            {
                return 30;
            }

            if (estructura[0] == '#')
            {
                return 90;
            }

            return 0;
        }

        public bool EstaBienConstruida()
        {
            if (estructura.Length == 0)
            {
                return false;
            }

            if (estructura[0] != '%' &&
                estructura[0] != '&' &&
                estructura[0] != '#')
            {
                return false;
            }

            for (int i = 1; i < estructura.Length; i++)
            {
                if (estructura[i] != '=' &&
                    estructura[i] != '*')
                {
                    return false;
                }

                if (estructura[i] == '*' && estructura[i - 1] == '*')
                {
                    return false;
                }

                if (estructura[i] == '*' && estructura[i - 1] != '=')
                {
                    return false;
                }
            }

            return true;
        }

        public int CalcularPeso()
        {
            int pesoTotal = 0;
            int largueroActual = 0;

            for (int i = 1; i < estructura.Length; i++)
            {
                if (estructura[i] == '=')
                {
                    largueroActual++;
                }
                else if (estructura[i] == '*')
                {
                    pesoTotal += largueroActual;       
                    pesoTotal += largueroActual * 2;   
                    largueroActual = 0;
                }
            }

            pesoTotal += largueroActual; 
            return pesoTotal;
        }

        public bool SoportaPeso()
        {
            int resistencia = ObtenerResistencia();
            int peso = CalcularPeso();

            return peso <= resistencia;
        }
    }
}