using System.Text.RegularExpressions;

public static class InputValidator
{
    // R1: B oder C, gefolgt von genau drei Ziffern (z. B. B203)
    public static bool IsValidRoom(string input)
        => Regex.IsMatch(input, @"[BC][0-9]{3}");

    // R2: 4 bis 12 Zeichen: Buchstaben (A-Z, a-z), Ziffern oder _
    public static bool IsValidUsername(string input)
        => Regex.IsMatch(input, @"^[A-Za-z0-9_]{3,12}$");

    // R3: Genau fünf Ziffern, die erste darf nicht 0 sein
    public static bool IsValidStudentId(string input)
        => Regex.IsMatch(input, @"^[0-9]{5}$");

    // R4: ID-, danach mindestens ein Buchstabe oder eine Ziffer, Endung .txt
    // TODO: Implementieren
    public static bool IsValidFilename(string input)
        => false;
}
