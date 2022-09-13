# Lern-Bericht
Timo Goedertier
1. Tester: Tristan Evans
2. Tester: Julius Burlet

## Einleitung

In meinem Programm werden zufällig Zahlen- generiert, in einem Zahlenbereich, der vom Spieler gewählt wurde. 

## Was habe ich gelernt?

✍️ Beschreiben Sie in einem Satz **eine** Sache, die Sie bei diesem Projekt gelernt haben und die Sie in diesem Lern-Bericht dokumentieren.

## Beschreibung

Ich habe am Anfang, bevor ich angefangen habe am Projekt zu programieren, ein PAP erstellt welches mir geholfen hat das ganze Programm zu schreiben und zu verstehen.
![image](https://user-images.githubusercontent.com/110891995/186114469-ca121daf-4013-4dfc-82f9-98bb753c76b5.png)


Ich bin sehr stolz auf diesen Teil des Codes, denn ich habe die meiste Zeit reingesteckt und ich denke dies ist auch der komplizierteste Teil vom ganzen Code.

```
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
Beim ersten "if" testet das Programm ob die eingegebene Zahl in der Variabel ``guessint`` grösser ist wie die generierte Zahl in ``num`` und ob ``guessint`` innerhalb des gewählten Zahlenbereichs ``diff`` ist.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
