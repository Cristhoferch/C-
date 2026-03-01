using System;
using System.Collections.Generic;

class TraductorBasico
{
    static void Main()
    {
        // Diccionario Español -> Inglés
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"ojo", "eye"}
        };

        int opcion;

        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;

                case 2:
                    AgregarPalabra(diccionario);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();

        string[] palabras = frase.Split(' ');
        string fraseTraducida = "";

        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
            {
                fraseTraducida += diccionario[palabra] + " ";
            }
            else
            {
                fraseTraducida += palabra + " ";
            }
        }

        Console.WriteLine("Traducción:");
        Console.WriteLine(fraseTraducida.Trim());
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en español: ");
        string espanol = Console.ReadLine().ToLower();

        if (diccionario.ContainsKey(espanol))
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
            return;
        }

        Console.Write("Ingrese la traducción al inglés: ");
        string ingles = Console.ReadLine().ToLower();

        diccionario.Add(espanol, ingles);
        Console.WriteLine("Palabra agregada correctamente.");
    }
}
