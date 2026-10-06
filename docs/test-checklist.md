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

## Teknisk kontroll

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| `dotnet build` | Projektet bygger | 0 errors och 0 warnings | Godkänd | 2026-10-05 |

## Tester som återstår senare

De här testerna kan inte göras än, eftersom funktionerna inte är byggda:

- Avbokning av ett bokat pass.
- Ändra personuppgifter.
- Hela storyn för profil och Mina bokningar, med alla dess acceptanskriterier.
- Admin skapar träningspass.
- Admin redigerar träningspass.
- Admin tar bort träningspass.
- Schema eller kalenderöversikt.
- Slutlig responsiv kontroll på mobil, surfplatta och dator.
