# Testprotokoll

| Requirement | Eingabe | Erwartet | Tatsächlich | Status |
|---|---|---|---|---|
| R1 | B203 | gültig | gültig | bestanden |
| R1 | XYZB203ABC | ungültig | ungültig | bestanden |
| R1 | C101 | gültig | gültig | bestanden |
| R1 | B12 | ungültig | ungültig | bestanden |
| R1 | B1234 | ungültig | ungültig | bestanden |
| R1 | D203 | ungültig | ungültig | bestanden |
| R2 | max_2026 | gültig | gültig | bestanden |
| R2 | abc | ungültig | ungültig | bestanden |
| R2 | abcd | gültig | gültig | bestanden |
| R2 | user_1234567 | gültig | gültig | bestanden |
| R2 | user_12345678 | ungültig | ungültig | bestanden |
| R2 | max! | ungültig | ungültig | bestanden |
| R3 | 12345 | gültig | gültig | bestanden |
| R3 | 01234 | ungültig | ungültig | bestanden |
| R3 | 99999 | gültig | gültig | bestanden |
| R3 | 1234 | ungültig | ungültig | bestanden |
| R3 | 123456 | ungültig | ungültig | bestanden |
| R3 | 12a45 | ungültig | ungültig | bestanden |
| R4 | ID-Test7.txt | gültig | gültig | bestanden |
| R4 | ID-.txt | ungültig | ungültig | bestanden |
| R4 | ID-A.txt | gültig | gültig | bestanden |
| R4 | Test7.txt | ungültig | ungültig | bestanden |
| R4 | ID-Test7.csv | ungültig | ungültig | bestanden |
| R4 | ID-Test_7.txt | ungültig | ungültig | bestanden |

Ergänzt mindestens vier eigene Testfälle, darunter einen Grenzfall.
