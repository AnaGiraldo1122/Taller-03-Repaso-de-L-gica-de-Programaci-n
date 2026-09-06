using Ejercicio28;
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var estructura = ConsoleExtension.GetString("Ingrese la viga: ")!;

    var viga = new Viga(estructura);

    if (!viga.EstaBienConstruida())
    {
        Console.WriteLine("La viga está mal construida!");
    }
    else if (viga.SoportaPeso())
    {
        Console.WriteLine("La viga soporta el peso!");
    }
    else
    {
        Console.WriteLine("La viga NO soporta el peso!");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions(
            "¿Deseas continuar [S]í, [N]o?....: ",
            options);
    }
    while (!options.Any(x =>
        x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");