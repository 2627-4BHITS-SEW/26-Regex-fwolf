# Testprotokoll

| Requirement | Eingabe | Erwartet | Tatsächlich | Status |
|---|---|---|---|---|
| R1 | B203 | gültig | gültig | bestanden |
| R1 | XYZB203ABC | ungültig | ungültig | bestanden |
| R1 | B203B203 | ungültig | ungültig | bestanden |
| R2 | max_2026 | gültig | gültig | bestanden |
| R2 | abc | ungültig | ungültig | bestanden |
| R2 | abcd | gültig | gültig | bestanden |
| R2 | abcdefghijklm | ungültig | ungültig | bestanden |
| R2 | max! | ungültig | ungültig | bestanden |
| R3 | 12345 | gültig | | |
| R3 | 01234 | ungültig | | |
| R4 | ID-Test7.txt | gültig | | |
| R4 | ID-.txt | ungültig | | |

Ergänzt mindestens vier eigene Testfälle, darunter einen Grenzfall.
