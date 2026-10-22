# Testprotokoll

| Requirement | Eingabe | Erwartet | Tatsächlich | Status |
|---|---|---|---|---|
| R1 | B203 | gültig | | |
| R1 | XYZB203ABC | ungültig | | |
| R2 | max_2026 | gültig | | |
| R2 | abc | ungültig | | |
| R3 | 12345 | gültig | | |
| R3 | 01234 | ungültig | | |
| R4 | ID-Test7.txt | gültig | gültig | bestanden |
| R4 | ID-.txt | ungültig | ungültig | bestanden |
| R4 | ID-A.txt | gültig | gültig | bestanden |
| R4 | Test7.txt | ungültig | ungültig | bestanden |
| R4 | ID-Test7.csv | ungültig | ungültig | bestanden |
| R4 | ID-Test_7.txt | ungültig | ungültig | bestanden |

Ergänzt mindestens vier eigene Testfälle, darunter einen Grenzfall.
