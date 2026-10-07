# Testchecklista – Core Gym Club Bokningssystem

Här samlar jag de tester jag faktiskt har gjort i projektet. Testerna är
manuella och körda i webbläsaren mot appen som startats lokalt med
`dotnet run`. Kolumnen "Verifierat" visar vilken dag testet gjordes.

Testerna nedan gäller funktioner som är klara och mergade till `main`.

## Användarhantering

| Test | Förväntat resultat | Resultat | Verifierat |
|---|---|---|---|
| Registrering av ny användare | Kontot skapas och en bekräftelse visas | Godkänd | 2026-10-05 |
| Login med korrekt lösenord | Användaren loggas in | Godkänd | 2026-10-05 |
| Login med fel lösenord | Ett tydligt felmeddelande visas | Godkänd | 2026-10-05 |
| Skyddad profilsida som utloggad | Användaren skickas till inloggningssidan | Godkänd | 2026-10-05 |
| Logout | Användaren loggas ut, och skyddade sidor kräver inloggning igen | Godkänd | 2026-10-05 |

## Träningspass

| Test | Förväntat resultat | Resultat | Verifierat |
|---|---|---|---|
| Lista över kommande träningspass visas | Passen listas med titel, datum, tid, plats, instruktör och lediga platser | Godkänd | 2026-09-22 |
| Ett träningspass kan öppnas på en detaljsida | Passet går att klicka på och öppnas | Godkänd | 2026-10-04 |
| Detaljsidan visar passets information | Beskrivning, datum, tid, plats, instruktör och lediga platser visas | Godkänd | 2026-10-04 |

## Bokning

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| Inloggad medlem bokar Core och balans | Bokningen sparas och en bekräftelse visas | Bokningen sparades och bekräftelsen visades | Godkänd | 2026-10-05 |
| Lediga platser efter bokning | Antalet minskar med ett | Före: 16, efter: 15 | Godkänd | 2026-10-05 |
| Bokningen visas under Mina bokningar | Core och balans visas med datum och tid | Passet visades med datum och tid | Godkänd | 2026-10-05 |
| Dubbelbokning av samma pass | Samma användare kan inte boka samma pass igen | "Du har redan bokat det här passet." | Godkänd | 2026-10-05 |
| Fullbokat pass, HIIT Express med 0 lediga platser | Passet kan inte bokas | Detaljsidan visar "Passet är fullbokat." i stället för bokningsknappen. Ett bokningsförsök svarar "Passet är fullbokat, så det finns inga lediga platser kvar." | Godkänd | 2026-10-05 |

## Profil och personuppgifter

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| Profilsidan visar användarens uppgifter | E-post, namn och telefonnummer visas | Alla tre visades | Godkänd | 2026-10-07 |
| Namn och telefonnummer kan ändras | Fälten går att redigera och spara | Namnet ändrades till "Alidur Hamid Test" och telefonnumret sparades, med meddelandet "Dina personuppgifter är sparade." | Godkänd | 2026-10-07 |
| Ändringarna finns kvar efter ny request | De sparade uppgifterna visas på profilen | De uppdaterade uppgifterna visades | Godkänd | 2026-10-07 |
| Ogiltigt telefonnummer | Ett valideringsfel visas och inget sparas | "Ange ett giltigt telefonnummer." och ingenting sparades | Godkänd | 2026-10-07 |

## Avbokning

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| Kommande bokningar visas under Mina bokningar | Användarens kommande bokningar listas | Core och balans visades | Godkänd | 2026-10-07 |
| Varje bokning visar passets uppgifter | Titel, datum och tid visas | Alla tre visades | Godkänd | 2026-10-07 |
| Avbokning av en bokning | Bokningen tas bort | Avbokningen gick igenom | Godkänd | 2026-10-07 |
| Bokningen försvinner efter avbokning | Bokningen visas inte längre under Mina bokningar | Listan var tom efteråt | Godkänd | 2026-10-07 |
| Lediga platser efter avbokning | Antalet ökar med ett | Core och balans gick från 15 till 16 | Godkänd | 2026-10-07 |
| Bekräftelse efter avbokning | Ett tydligt meddelande visas | "Din bokning av Core och balans har avbokats." | Godkänd | 2026-10-07 |
| Avboka någon annans bokning | Ska inte vara möjligt | Försöket gav 404 och bokningen låg kvar | Godkänd | 2026-10-07 |

## Teknisk kontroll

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| `dotnet build` | Projektet bygger | 0 errors och 0 warnings | Godkänd | 2026-10-07 |

## Tester som återstår senare

De här testerna kan inte göras än, eftersom funktionerna inte är byggda:

- Admin skapar träningspass.
- Admin redigerar träningspass.
- Admin tar bort träningspass.
- Schema eller kalenderöversikt.
- Slutlig responsiv kontroll på mobil, surfplatta och dator.
