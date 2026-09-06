namespace Ejercicio37
{
    public class Caballo
    {
        public string ubicacion;

        public Caballo(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public bool EstaEnConflicto(Caballo otroCaballo)
        {
            char columna1 = ubicacion[0];
            int fila1 = int.Parse(ubicacion[1].ToString());

            char columna2 = otroCaballo.ubicacion[0];
            int fila2 = int.Parse(otroCaballo.ubicacion[1].ToString());

            int diferenciaColumnas = Math.Abs(columna1 - columna2);
            int diferenciaFilas = Math.Abs(fila1 - fila2);

            return (diferenciaColumnas == 1 && diferenciaFilas == 2) ||
                   (diferenciaColumnas == 2 && diferenciaFilas == 1);
        }
    }
}