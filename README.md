# School Input Validator – 4BHITS SEW

Eine C#-Konsolenanwendung zur Validierung von Eingaben mit Regex.

## Voraussetzungen
- .NET SDK 8 oder neuer

## Ausführen
```bash
dotnet run
```

## Anforderungen
- **R1 Raum:** B oder C, gefolgt von genau 3 Ziffern (z. B. `B203`).
- **R2 Benutzername:** 4–12 Zeichen, ausschließlich A–Z, a–z, 0–9 oder `_`.
- **R3 Schüler-ID:** genau 5 Ziffern, erste Ziffer ist 1–9.
- **R4 Dateiname:** `ID-`, gefolgt von mindestens einem Buchstaben oder einer Ziffer, Endung `.txt` (z. B. `ID-Test7.txt`).

## Reguläre Ausdrücke und ihre Bedeutung

### R1 – Raum (`^[BC][0-9]{3}$`)
- `^`: Verankert das Suchmuster am Anfang des Strings.
- `[BC]`: Erlaubt an erster Stelle genau ein Zeichen, entweder `B` oder `C`.
- `[0-9]{3}`: Genau drei Ziffern (0–9).
- `$`: Verankert das Suchmuster am Ende des Strings (verhindert vorangehenden oder nachfolgenden Text).

### R2 – Benutzername (`^[A-Za-z0-9_]{4,12}$`)
- `^`: Anfang des Strings.
- `[A-Za-z0-9_]{4,12}`: Erlaubt Großbuchstaben (`A-Z`), Kleinbuchstaben (`a-z`), Ziffern (`0-9`) und den Unterstrich (`_`) mit einer Gesamtlänge von mindestens 4 bis maximal 12 Zeichen.
- `$`: Ende des Strings.

### R3 – Schüler-ID (`^[1-9][0-9]{4}$`)
- `^`: Anfang des Strings.
- `[1-9]`: Genau eine Ziffer von 1 bis 9 (schließt die `0` an erster Stelle aus).
- `[0-9]{4}`: Genau vier weitere Ziffern von 0 bis 9 (zusammen mit der ersten Ziffer exakt 5 Ziffern).
- `$`: Ende des Strings.

### R4 – Dateiname (`^ID-[A-Za-z0-9]+\.txt$`)
- `^`: Anfang des Strings.
- `ID-`: Exakter Präfix `ID-`.
- `[A-Za-z0-9]+`: Mindestens ein alphanumerisches Zeichen (`+` = 1 oder mehr Buchstaben/Ziffern; schließt z. B. `_` oder Leerzeichen aus).
- `\.txt`: Der Punkt muss mit einem Backslash maskiert werden (`\.`), da ein unmaskierter `.` jedes beliebige Zeichen matchen würde, gefolgt von `txt`.
- `$`: Ende des Strings.

## Arbeitsweise
Arbeitet in Zweierteams. Legt für jedes Issue einen eigenen Branch an, behebt den Fehler und eröffnet einen Pull Request. Die zweite Person prüft den Pull Request vor dem Merge. Haltet Testfälle und Ergebnisse in `TESTS.md` fest.

## Aufgaben
Die Aufgaben werden als GitHub Issues angelegt (Vorlagen im Ordner `issues/`). Der Code enthält absichtlich Fehler und eine noch nicht implementierte Funktion.
