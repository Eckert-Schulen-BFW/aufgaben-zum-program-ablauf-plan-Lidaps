// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
//
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort: Wenn Tryparse false
//
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: Weil Tryparse überprüft also versucht zu parsen. Bei false wird false ausgegeben bei converttodouble würde das Programm abstürzen
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort: Double weil Kommazahlen
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.
using System;






// Start
// Ausgabe: Bitte Namen eingeben
System.Console.WriteLine("Bitte Namen eingeben!");
//Eingabe Name
string? strname = Console.ReadLine();
strname = strname != null ? strname : "Falsche Eingabe";
//Ausgabe
System.Console.WriteLine("Bitte Gewicht in kg eingeben!");
double doubleWeight = -1;
string? strWeight = Console.ReadLine();
bool boolWeight = double.TryParse(strWeight, out doubleWeight);
if (boolWeight == !true)
{
    Console.WriteLine("Fehler Ungültige \n Eingabe");

}
;

Console.WriteLine("Bitte Größe in meter eingeben!");
double dblGroese = -1;
string? strGroese = Console.ReadLine();
bool blGroese = double.TryParse(strGroese, out dblGroese);
if (blGroese == false)
{
    Console.WriteLine("Fehler Ungültige \n Eingabe");

}
;


if (dblGroese < 0)
{
    System.Console.WriteLine("Fehler \nGröße muss psitiv sein");


}
// Berechnung BMI = Gewicht / (Größe x Größe)

double dbBmi = -1;

dbBmi = doubleWeight / (dblGroese * dblGroese);
string kat = "";
if (dbBmi < 18.5)
{
    kat = "Untergewicht";
}
else if (dbBmi < 25)
{
    kat = "Normalgewicht";
}
else if (dbBmi < 30)
{
    kat = "Übergewicht";
}
else
{
    kat = "Starkes Übergewicht";
}


Console.WriteLine($"Der BMI von {strname} ist {kat}  und at den Wert {dbBmi:F2}");








// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)


// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)


// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)


// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)


// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern


// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?


// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen
