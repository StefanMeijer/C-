# Startdocument voor verhuur van speedboten 

Startdocument van **Stefan Meijer**. Studentnummer **5033454**.

## Probleem beschrijving

Een bedrijf verhuurt speedboten. Voor één bepaalde dag wordt elk van de
tien aanwezige speedboten hoogstens 1 keer verhuurd.

Er dient een programma te worden ontwikkeld waarmee de administratie van
één dag bijgehouden kan worden. Per boot worden de volgende gegevens
vastgelegd: gewicht, aantal pk’s motorvermogen, lengte en bootnummer en de
huurprijs per uur. Verder wordt afhankelijk van de verbruikte hoeveelheid
brandstof een verhuurtoeslag van 5 euro per liter berekend. Voor verhuurde
boten wordt vastgelegd aanvangstijd verhuur, eindtijd verhuur, aantal liters
verbruikte brandstof en opgelopen schade.
Aan het einde van de dag wil de eigenaar de volgende gegevens gepresenteerd
hebben:
> De totale omzet over alle boten;
> De totale verhuurtijd over alle boten;
> Het nummer van de boot met het hoogste brandstofverbruik per
minuut tezamen met dit verbruik;
> Het percentage van de verhuurde boten dat schade heeft opgelopen;
> De boot die het kortst is verhuurd.

### Invoer & uitvoer
In dit gedeelte worden de invoer en uitvoer van de applicatie beschreven.

#### Invoer
In de tabel hieronder worden alle invoeren (die de gebruiker moet invoeren om de applicatie te laten werken) beschreven

|Case|Type|Conditions|
|----|----|----------|
|Naam van het bedrijf|`String`|not empty||
Het nummer van een boot|`Int` |not empty|
|Het gewicht van een boot|`Double` |not empty|
|Het aantal pk's motorvermogen van een boot|`Int`|not empty|
|De lengte van een boot|`Double`|not empty|
|De huurprijs per uur van een boot|`Double`|not empty|
|De aanvangstijd van een verhuur|`Time`|HH:mm|
|De eindtijd van een verhuur|`Time`|HH:mm|
|Verbruikte liters bij een verhuur|`Double`|not empty|
|Opgelopen schade bij een verhuur|`Boolean`||

#### Uitvoer

|Case|Type|
|----|----|
|Totale omzet van alle boten|`Double`|
|Totale verhuurtijd van alle boten|`Time`|
|Nummer van de boot met het hoogste brandstofverbruik per minuut|`Int`|
|Percentage van de boten die schade hebben|`Double`|
|De boot die het korste verhuurd is|`Speedboot`|
|Omzet van één boot|`Double`|
|Brandstofverbruik van één boot|`Double`|
|Verhuurtijd van één boot|`Time`|

#### Berekeningen

| Case              | Berekening                        |
| ----------------- | ---------------------------------- |
| Totale omzet van alle boten | Loop over List, tel alle omzet van alle boten bij elkaar op |
| Totale verhuurtijd van alle boten | Loop over List, tel alle totale verhuurtijden bij elkaar op |
| Nummer van de boot met het hoogste brandstofverbruik per minuut | Loop over List, pak het nummer van de boot met de laagste brandstof verbruik per minuut |
| Percentage van de boten die schade hebben | Loop over List, 100 : Het aantal boten  x de boten met scahde  |

## Klassendiagram

![Klassendiagram](https://i.imgur.com/aVa1cgp.png "First Version of the class diagram")

## Testplan

In deze sectie zullen de test cases beschreven worden om te applicatie te testen voor de gewenste uitvoer.

### Test Cases

In deze sectie zullen de test cases beschreven worden. Elke test case zou moeten worden uitgevoerd met de test data als start punt.

#### #1 Totale omzet van alle boten
Totale omzet van alle boten
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| n.v.t. | Klik op de knop 'Totale omzet alle boten'| In de label eronder komt de totale omzet te staan van alle boten |

#### #2 Totale verhuurtijd van alle boten	
Totale verhuurtijd van alle boten	
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| n.v.t. | Klik op de knop 'Totale verhuurtijd alle boten'| In de label eronder komt de totale verhuurtijd te staan van alle boten |

#### #3 Nummer van de boot met het hoogste brandstofverbruik per minuut	
Nummer van de boot met het hoogste brandstofverbruik per minuut	
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| n.v.t. | Klik op de knop 'Boot met het hoogste brandstofverbruik'| In de label eronder komt de bootnummer te staan met het hoogste brandstofverbruik per minuut |

#### #4 Percentage van de boten die schade hebben
Percentage van de boten die schade hebben
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| n.v.t. | Klik op de knop 'Percentage van de boten die schade hebben'| In de label eronder komt het percentage te staan van alle boten die schade hebben |

#### #5 De boot die het korste verhuurd is	
De boot die het korste verhuurd is	
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| n.v.t. | Klik op de knop 'Boot die het korst verhuurd is'| In de label eronder komt de boot te staan die het korst verhuurd is|

#### #6 Omzet van één boot	
Omzet van één boot	
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| Nummer, gewicht, pk's, lengte en huurprijs van de boot | Voer velden in | ||
|2| n.v.t. | Klik op de knop 'Omzet van de speedboot' | In de label eronder komt de omzet van de speedboot te staan |

#### #7 Brandstofverbruik van één boot		
Brandstofverbruik van één boot	
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| Nummer, gewicht, pk's, lengte en huurprijs van de boot | Voer velden in | |
|2| n.v.t. | Klik op de knop 'Brandstofverbruik van de speedboot' | In de label eronder komt de brandstofverbruik van de speedboot te staan ||

#### #8 Verhuurtijd van één boot	
Verhuurtijd van één boot
|Stap|Invoer|Actie|Verwachte uitkomst|
|----|-----|------|---------------|
|1| Nummer, gewicht, pk's, lengte en huurprijs van de boot | Voer velden in | |
|2| aanvangstijd en eindtijd van de boot | voer velden in |  |
|3| n.v.t. | Klik op de knop 'Verhuurtijd van de speedboot' | In de label eronder komt de verhuurtijd van de speedboot te staan ||

|Invoer||||||||Uitvoer|||
|-|-|-|-|-|-|-|-|-|-|-|
|Nummer|Gewicht|pk's|lengte|huurprijs|aanvangstijd|eindtijd|Liters|omzet|brandstofverbruik|verhuurtijd|
| 1 | 560 | 100 | 1,60 | 60 | 09:00 | 10:00 | 2.5 | 72,5 | 24 | 01:00 |
| 2 | 550 | 105 | 1,20 | 60 | 09:00 | 10:00 | 2.3 | 71,5 | 26,1 | 01:00 |
| 3 | 575 | 125 | 1,55 | 60 | 09:00 | 10:00 | 4   | 80   | 15 | 01:00 |
| 4 | 600 | 150 | 1,50 | 60 | 09:00 | 10:00 | 6   | 90   | 10 | 01:00 |
| 5 | 490 | 95  | 1,35 | 60 | 09:00 | 10:00 | 2   | 60   | 30 | 01:00 |
