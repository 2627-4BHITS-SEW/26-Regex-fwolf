# Testprotokoll

| Requirement | Eingabe | Erwartet | Tatsächlich | Status |
|---|---|---|---|---|
| R1 | B203 | gültig | | |
| R1 | XYZB203ABC | ungültig | | |
| R2 | max_2026 | gültig | | |
| R2 | abc | ungültig | | |
| R3 | 12345 | gültig | gültig | bestanden |
| R3 | 01234 | ungültig | ungültig | bestanden |
| R3 | 1234 | ungültig | ungültig | bestanden |
| R4 | ID-Test7.txt | gültig | | |
| R4 | ID-.txt | ungültig | | |

Ergänzt mindestens vier eigene Testfälle, darunter einen Grenzfall.