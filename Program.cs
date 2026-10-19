using System;

Console.WriteLine("=== School Input Validator ===");
Console.WriteLine("1 - Raum");
Console.WriteLine("2 - Benutzername");
Console.WriteLine("3 - Schüler-ID");
Console.WriteLine("4 - Dateiname");
Console.Write("Auswahl: ");
string? choice = Console.ReadLine();
Console.Write("Eingabe: ");
string input = Console.ReadLine() ?? "";

bool? result = choice switch
{
    "1" => InputValidator.IsValidRoom(input),
    "2" => InputValidator.IsValidUsername(input),
    "3" => InputValidator.IsValidStudentId(input),
    "4" => InputValidator.IsValidFilename(input),
    _ => null
};
Console.WriteLine(result is null ? "Unbekannte Auswahl" : result.Value ? "Gültig" : "Ungültig");
