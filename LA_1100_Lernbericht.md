# Lern-Bericht
Timo Goedertier
  1. Tester: Tristan Evans
  2. Tester: Julius Burlet

## Einleitung

In meinem Programm werden zufällig Zahlen- generiert, in einem Zahlenbereich, der vom Spieler gewählt wurde. 

## Was habe ich gelernt?

Ich habe gelernt, in C# einen Zahlengenerator zu programmieren und diesen so zu gestalten, damit man daraus ein kleines Konsolen-Spiel hat.

## Beschreibung

### Ich habe am Anfang, bevor ich angefangen habe am Projekt zu programmieren, ein PAP erstellt, welches mir geholfen hat, das ganze Programm zu schreiben und zu verstehen.

<img src="https://user-images.githubusercontent.com/110891995/186114469-ca121daf-4013-4dfc-82f9-98bb753c76b5.png" alt="Kreis Vorlage" width="600"/>

### Ich bin sehr stolz auf diesen Teil des Codes, denn ich habe die meiste Zeit reingesteckt und ich denke dies ist auch der komplizierteste Teil vom ganzen Code.

```c#
while (num != guessint)
                    {
                        if (num < guessint && guessint <= diff && guessint >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu gross. ");
                        }
                        if (num > guessint && guessint <= diff && guessint >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu klein. ");
                        }
                        if (guessint > diff || guessint < 1) 
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ihre Zahl ist ungültig. Bitte geben Sie eine gültige Zahl ein. ");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        guessint = Convert.ToInt32(Console.ReadLine());
                    }
```

**Resultat des obigen Codes:**

![image](https://user-images.githubusercontent.com/110891995/189850044-0b970712-af6f-4b22-bbf2-c219761c3cbc.png)

Beim ersten *if{}* guckt das Programm, ob die eingegebene Zahl in der Variabel ``guessint`` grösser ist, wie die generierte Zahl in ``num`` und ob ``guessint`` innerhalb des gewählten Zahlenbereichs ``diff`` ist, wenn dies der Fall ist, wird gesagt, dass ``guessint`` zu gross ist.

Beim zweiten *if{}* guckt das Programm, ob ``guessint`` kleiner ist, wie die generierte Zahl in ``num`` und ob ``guessint`` innerhalb des gewählten Zahlenbereichs ``diff`` ist, wenn dies der Fall ist, wird gesagt, dass ``guessint`` zu klein ist.

Beim dritten *if{}* guckt das Programm, ob ``guessint`` im Zahlenbereich ``diff`` ist, wenn nicht, dann wird gesagt, dass die Zahl ungültig ist.


### Die Funktion try{} catch{} hat mir auch sehr geholfen bei Eingaben, die man nicht eingeben soll.
```c#
try
{
Console.WriteLine("Geben Sie Ihren Namen ein.");
string eingabe = Console.ReadLine();
}
catch
{
Console.WriteLine("Ungültige Eingabe");
Console.WriteLine("Sie müssen Ihren Namen eingeben als Buchstaben, keine anderen Charakter.");
}
```
Mit dieser Funktion wird, hier jetzt bei ``string eingabe = Console.ReadLine();`` ein Name eingegeben, welcher im string ``eingabe`` gespeichert wird und *try{} catch{}* guckt, ob die Eingabe ein string ist, ist die Eingabe **kein** string geht das Programm von *try{}* zu *catch{}* und im catch steht dann, warum die Eingabe falsch oder ungültig ist.

## Verifikation

-Das PAP hat mir sehr geholfen auf dem richtigen Pfad zu bleiben und nicht unnötiges und/oder zusätzliches, welches ich nicht brauche dazu zu programmieren.

-Mit dem Einfügen eines Teils von meinem Code, wollte ich zeigen, dass ich gelernt habe mit *if{}* umzugehen und wie *if{}* funktioniert und dass ich in der Kondition vom *if{}* Zahlen-Vergleiche eingeben kann.

-Ich habe gelernt *try{} catch{}* zu benutzen und wie diese Funktion genau funktioniert.

# Reflexion zum Arbeitsprozess

### Dies lief gut:
-Ich konnte immer gut arbeiten
-Ich habe immer alles was ich mir vorgenommen habe gelöst und fertig gemacht

### Dies lief nicht gut:
-Ich habe mich manchmal von meinen Klassenkameraden ablenken lassen.
-Ich musste immer wieder mal in gewisse Presentationen schauen, was welche Variabeln oder Funktionen machen.

**VBV**: Ich muss alle Variabeln und Funktionen, die wir im Unterricht hatten, auswendig lernen.
