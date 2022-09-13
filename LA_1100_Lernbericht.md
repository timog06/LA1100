# Lern-Bericht
Timo Goedertier
1. Tester: Tristan Evans
2. Tester: Julius Burlet

## Einleitung

In meinem Programm werden zufällig Zahlen- generiert, in einem Zahlenbereich, der vom Spieler gewählt wurde. 

## Was habe ich gelernt?

Ich habe gelernt, in C# einen Zahlengenerator zu programmieren und diesen so zu gestalten, damit man daraus ein kleines Konsolen-Spiel hat.

## Beschreibung

### Ich habe am Anfang, bevor ich angefangen habe am Projekt zu programieren, ein PAP erstellt welches mir geholfen hat das ganze Programm zu schreiben und zu verstehen.

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
Beim ersten "if" guckt das Programm ob die eingegebene Zahl in der Variabel ``guessint`` grösser ist, wie die generierte Zahl in ``num`` und ob ``guessint`` innerhalb des gewählten Zahlenbereichs ``diff`` ist, wenn dies der fall ist wird gesagt, dass ``guessint`` zu gross ist.

Beim zweiten "if" guckt das Programm ob ``guessint`` kleiner ist, wie die generierte Zahl in ``num`` und ob ``guessint`` innerhalb des gewählten Zahlenbereichs ``diff`` ist, wenn dies der fall ist wird gesagt, dass ``guessint`` zu klein ist.

Beim dritten "if" guckt das Programm ob ``guessint`` im Zahlenbereich ``diff`` ist, wenn nicht dann wird gesagt dass die Zahl ungültig ist.


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
Mit dieser Funktion wird, hier jetzt bei ``string eingabe = Console.ReadLine();`` ein Name eingegeben, welcher im string ``eingabe`` gespeichert wird und *try{} catch{}* guckt, ob die Eingabe ein string ist, ist die Eingabe **kein** string geht das Programm von try{} zu catch{} und im catch steht dann, warum kdie Eingabe falsch oder ungültig ist.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
