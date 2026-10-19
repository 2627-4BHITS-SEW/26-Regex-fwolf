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

## Arbeitsweise
Arbeitet in Zweierteams. Legt für jedes Issue einen eigenen Branch an, behebt den Fehler und eröffnet einen Pull Request. Die zweite Person prüft den Pull Request vor dem Merge. Haltet Testfälle und Ergebnisse in `TESTS.md` fest.

## Aufgaben
Die Aufgaben werden als GitHub Issues angelegt (Vorlagen im Ordner `issues/`). Der Code enthält absichtlich Fehler und eine noch nicht implementierte Funktion.
