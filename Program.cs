using System;

class Program
{
    static void Main()
    {
        // Afficher un menu d'options à l'utilisateur
        Console.WriteLine($"{Environment.NewLine}Convertisseur d'unités de longueur");
        Console.WriteLine($"{Environment.NewLine}Choisissez l'unité de départ:");
        Console.WriteLine("1. Mètres");
        Console.WriteLine("2. Kilomètres");
        Console.WriteLine("3. Centimètres");
        Console.WriteLine("4. Millimètres");

        // Lire l'option de l'utilisateur
        int optionFrom = int.Parse(Console.ReadLine());

        // Demander l'unité de destination
        Console.WriteLine($"{Environment.NewLine}Choisissez l'unité de destination:");
        Console.WriteLine("1. Mètres");
        Console.WriteLine("2. Kilomètres");
        Console.WriteLine("3. Centimètres");
        Console.WriteLine("4. Millimètres");

        // Lire l'option de l'utilisateur pour la destination
        int optionTo = int.Parse(Console.ReadLine());

        // Demander à l'utilisateur de saisir la valeur à convertir
        Console.Write($"{Environment.NewLine}Entrez la valeur à convertir: ");
        double value = double.Parse(Console.ReadLine());

        // Variable pour stocker la valeur convertie
        double convertedValue = 0;

        // Logique pour la conversion
        if (optionFrom == 1 && optionTo == 2)
            convertedValue = value / 1000;  // Convertir des mètres en kilomètres
        else if (optionFrom == 1 && optionTo == 3)
            convertedValue = value * 100;  // Convertir des mètres en centimètres
        else if (optionFrom == 1 && optionTo == 4)
            convertedValue = value * 1000;  // Convertir des mètres en millimètres
        else if (optionFrom == 2 && optionTo == 1)
            convertedValue = value * 1000;  // Convertir des kilomètres en mètres
        else if (optionFrom == 2 && optionTo == 3)
            convertedValue = value * 100000;  // Convertir des kilomètres en centimètres
        else if (optionFrom == 2 && optionTo == 4)
            convertedValue = value * 1000000;  // Convertir des kilomètres en millimètres
        else if (optionFrom == 3 && optionTo == 1)
            convertedValue = value / 100;  // Convertir des centimètres en mètres
        else if (optionFrom == 3 && optionTo == 2)
            convertedValue = value / 100000;  // Convertir des centimètres en kilomètres
        else if (optionFrom == 3 && optionTo == 4)
            convertedValue = value * 10;  // Convertir des centimètres en millimètres
        else if (optionFrom == 4 && optionTo == 1)
            convertedValue = value / 1000;  // Convertir des millimètres en mètres
        else if (optionFrom == 4 && optionTo == 2)
            convertedValue = value / 1000000;  // Convertir des millimètres en kilomètres
        else if (optionFrom == 4 && optionTo == 3)
            convertedValue = value / 10;  // Convertir des millimètres en centimètres

        // Annoncer le résultat final avec la comparaison
        string unitFromString = GetUnitString(optionFrom);
        string unitToString = GetUnitString(optionTo);

        Console.WriteLine($"{Environment.NewLine}Vous avez converti {value} {unitFromString} en {convertedValue} {unitToString}.");
    }

    // Fonction pour obtenir le nom de l'unité en fonction du choix
    static string GetUnitString(int option)
    {
        switch (option)
        {
            case 1: return "mètres";
            case 2: return "kilomètres";
            case 3: return "centimètres";
            case 4: return "millimètres";
            default: return "inconnue";
        }
    }
}
