
using Ejercicio37;
using Shared;

var ubicaciones = ConsoleExtension.GetString("Ingrese ubicación de los caballos: ");

var posiciones = ubicaciones!.Split(',');

Caballo[] caballos = new Caballo[posiciones.Length];

for (int i = 0; i < posiciones.Length; i++)
{
    caballos[i] = new Caballo(posiciones[i].Trim());
}

for (int i = 0; i < caballos.Length; i++)
{
    Console.Write($"Analizando Caballo en {caballos[i].ubicacion[1]}{caballos[i].ubicacion[0]} =>");

    for (int j = caballos.Length - 1; j >= 0; j--)
    {

        if (i != j)
        {
            if (caballos[i].EstaEnConflicto(caballos[j]))
            {
                Console.Write($" Conflicto con {caballos[j].ubicacion[1]}{caballos[j].ubicacion[0]}");
            }
        }
    }

    Console.WriteLine();
}