# Projekt-Dokumentation

Inf22w Timo Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.2022      | 0.0.1   | Ich habe mit dem Planen angefangen.|
| 30.08.2022      | 0.1.0   |                                                    |
|                 | 1.0.0   |                                                    |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt soll ein Zahl Generator sein, in dem man die Zahlen erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |'muss'           |Funktion| Als Spieler möchte ich wissen, ob meine Zahl die richtig oder falsch ist.|
| 2    |'muss'           |Funktion| Als Spieler möchte ich mehrere Chancen bekommen, wenn meine Zahl falsch ist, damit es nicht immer eine neue Zahl generiert.|
| 3    |'muss'           |Funktion| Als Spieler möchte ich den Zahlenbereich verändern können. 
| 4    |'muss'           |Funktion| Als Spieler möchte ich, dass das Programm eine Rückmeldung gibt, ob meine Zahl zu hoch oder zu tief ist.|
| 5    |'muss'           |Funktion| Als Programmierer möchte ich dass der Spieler keine Buchstaben eingeben kann.|
| 6    |'muss'           |Qualität| Als Spieler möchte ich gefragt werden, ob ich noch eine Runde Spielen möchte.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Das Programm gibt keine Rückmeldung, ob die Zahl richtig oder falsch ist.|Der Spieler gibt eine Zahl ein und drückt enter.|Die Zahl ist richtig oder Falsch|
| 2.1  |Das Programm endet das Spiel nachdem der Spieler eine Zahl eingegeben hat, egal ob richtig oder falsch.|Der Spieler gibt eine falsche Zahl ein und drückt enter|Das Programm erkennt die falsche Zahl und gibt dem Spieler eine weitere Chance|
| 3.1  |Der Zahlenbereich ist fest bei 1-100|Sobald das Programm startet muss der Spieler einen Zahlenbereich eingeben im Stil x - y|Das Programm passt sich an den neuen Zahlenbereich an.|
| 4.1  |Das Programm gibt nur an ob die eingegebene Zahl richtig oder falsch ist an|Der Spieler gibt eine falsche Zahl an und drückt enter|Das Programm prüft ob die eingegebene Zahl oberhalb oder unterhalb der generierten Zahl ist und gibt dazu eine Rückmeldung|
| 5.1  |Das Programm stürzt ab|Der Spieler gibt Buchstaben ins programm ein|Das Programm erkennt dies und gibt eine Fehlermeldung beim Spieler ab.|gibt eine Rückmeldung zur richtigen Zahl ab und fragt den Spieler ob dieser noch eine Runde Spielen möchte.
| 6.1  |Das Programm endet sobald der Spieler die richtige Zahl eingegeben hat.|Der Spieler gibt die richtige Zahl ein und drückt enter|Das Programm |

### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/110891995/186114469-ca121daf-4013-4dfc-82f9-98bb753c76b5.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |30.08.2022|Timo Goedertier| Das Programm kann eine Zufällige Zahl generieren zwischen 1 und 100.| 30' |
| 1.B  |30.08.2022|Timo Goedertier| Das Programm macht eine Ausgabe ob die Zahl richtig oder falsch ist.| 30' |
| 2.A  |30.08.2022|Timo Goedertier| Das Programm soll, wenn eine Zahl falsh geschätzt wird, dem Spieler eine weitere Chance geben.| 45' |
| 3.A  |30.08.2022|Timo Goedertier| Der Spieler kann einen Zahlenbereich selber auswählen| 60' |
| 4.A  |30.08.2022|Timo Goedertier| Das Programm soll eine Rückmeldung geben, ob die Zahl des Spielers zu hoch oder zu tief ist.|45'|
| 5.A  |30.08.2022|Timo Goedertier| Das Programm soll eine Fehlermeldung Ausgeben, in der steht, dass man keine Buchstaben eingeben soll.|60'|
| 6.A  |30.08.2022|Timo Goedertier| Das Programm fragt den Spieler nach beenden der Runde, ob dieser noch eine Runde spielen möchte.|45'|
 
Total: 
`2` ╳ `1` ╳ `4` = 8 Arbeitspakete
8 Arbeitspakete sind 6h
-> Ich habe 5h15

## 3 Entscheiden

Ich werde ein Programm schreiben, in dem man, sobald das Programm gestartet wurde, man einen Zahlenbereich eingeben muss im Still x - y. Dann generiert das Programm in diesem Zahlenbereich eine Zahl. Der Spieler muss dann eine Zahl, im Zahlenbereich, schätzen bis er die richtige Zahl findet. Jedes mal, wenn der Spieler die falsche Zahl schätzt gibt das Programm eine Rückmeldung, in der steht ob die geschätzte Zahl höher oder tiefer als die generierte Zahl ist. Sobald der Spieler die generierte Zahl findet fragt das Programm, ob der Spieler noch eine Runde spielen möchte.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| 1.B  |       |           |               |                   |
| 2.A  |       |           |               |                   |
| 3.A  |       |           |               |                   |
| 4.A  |       |           |               |                   |
| 5.A  |       |           |               |                   |
| 6.A  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
