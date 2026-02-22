using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Universo: 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Conjunto Pfizer (75 ciudadanos)
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add($"Ciudadano {i}");
        }

        // Conjunto AstraZeneca (75 ciudadanos)
        HashSet<string> astraZeneca = new HashSet<string>();
        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add($"Ciudadano {i}");
        }

        // Operaciones de teoría de conjuntos

        // Ambas dosis (intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Solo Pfizer (diferencia)
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Solo AstraZeneca (diferencia)
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // No vacunados (complemento)
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Resultados
        MostrarListado("Ciudadanos NO vacunados", noVacunados);
        MostrarListado("Ciudadanos con AMBAS dosis", ambasDosis);
        MostrarListado("Ciudadanos SOLO Pfizer", soloPfizer);
        MostrarListado("Ciudadanos SOLO AstraZeneca", soloAstra);
    }

    static void MostrarListado(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n{titulo} ({conjunto.Count}):");
        foreach (var ciudadano in conjunto)
        {
            Console.WriteLine(ciudadano);
        }
    }
}