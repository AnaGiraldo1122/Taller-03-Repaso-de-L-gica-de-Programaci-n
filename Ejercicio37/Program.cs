using movCaballos;
using Shared;

string[] poscaballos = new string[6];
string[,] CaballosEnConflicto = new string[6, 2];

int indice = 0;
string Conflito;

Caballos Caballos = new Caballos();

string ubicaciones = ConsoleExtension.GetString("Ingrese ubicación de los caballos: ")!;

poscaballos = ubicaciones.Split(',');

Caballos.PosCabInTabAjedrez(poscaballos);

foreach (string cab in poscaballos)
{
    string[] PosibleMov = Caballos.MovimientInL(cab);

    for (int i = 0; i < poscaballos.Length; i++)
    {
        if (cab != poscaballos[i])
        {
            for (int j = 0; j < PosibleMov.Length; j++)
            {
                if (PosibleMov[j] == poscaballos[i])
                {
                    CaballosEnConflicto[indice, 0] = $"conflicto con {poscaballos[i]}";
                    CaballosEnConflicto[indice, 1] = cab;
                    indice += 1;
                    break;
                }
            }
        }
    }
}

for (int k = 0; k < poscaballos.Length; k++)
{
    Conflito = "";

    for (int t = 0; t < 6; t++)
    {
        if (poscaballos[k] == CaballosEnConflicto[t, 1])
        {
            Conflito = Conflito + " " + CaballosEnConflicto[t, 0];
        }
    }

    Console.WriteLine(
        value: $"Analizando Caballo en {poscaballos[k]} => {Conflito}"
    );
}