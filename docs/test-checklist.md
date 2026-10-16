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

## Administration av träningspass

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| Admin kan logga in | Adminkontot kan logga in | Inloggningen fungerade | Godkänd | 2026-10-14 |
| Admin kan öppna administrationen | Adminsidan visar alla träningspass | Alla pass listades med datum, tid, plats, instruktör, bokade och lediga platser | Godkänd | 2026-10-14 |
| Admin skapar ett träningspass | Passet sparas och en bekräftelse visas | Passet sparades och bekräftelsen visades | Godkänd | 2026-10-14 |
| Nytt pass syns i träningspasslistan | Passet finns i den vanliga listan och har en detaljsida | Passet visades i listan och detaljsidan visade alla uppgifter | Godkänd | 2026-10-14 |
| Admin redigerar ett träningspass | Ändringarna sparas | Titel, datum, tid, plats, instruktör och max antal deltagare uppdaterades | Godkänd | 2026-10-14 |
| Ändringen syns för medlemmar | Den uppdaterade informationen visas i listan och på detaljsidan | De nya uppgifterna visades | Godkänd | 2026-10-14 |
| Admin tar bort ett träningspass | Passet försvinner | Passet togs bort från administrationen och från den vanliga listan, och detaljsidan gav 404 | Godkänd | 2026-10-14 |
| Ogiltigt formulär | Valideringsfel visas och inget sparas | Svenska felmeddelanden visades och ingenting sparades | Godkänd | 2026-10-14 |
| Vanlig medlem försöker nå administrationen | Åtkomst nekas | Sidan "Ingen behörighet" visades, både via länk, direkt adress och POST | Godkänd | 2026-10-14 |
| Pass som inte finns | Hanteras säkert | Redigera och ta bort med okänt id gav 404 | Godkänd | 2026-10-14 |

## Schema

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| Schemasidan är publik | `/Classes/Schedule` kan öppnas utan inloggning, och länken "Schema" finns i menyn | Sidan öppnades utan inloggning via länken i menyn | Godkänd | 2026-10-15 |
| Bara kommande pass visas | Pass som redan har startat visas inte | Bara kommande pass visades | Godkänd | 2026-10-15 |
| Passen grupperas per datum | Varje dag får en egen rubrik med dagens pass under | Passen visades under rubriken för rätt datum | Godkänd | 2026-10-15 |
| Två pass samma dag | Båda visas under samma datum, sorterade efter tid | Båda passen visades under samma datum, i rätt tidsordning | Godkänd | 2026-10-15 |
| Passets uppgifter visas | Tid, titel, plats och instruktör visas | Alla fyra uppgifterna visades | Godkänd | 2026-10-15 |
| Passnamnet länkar till detaljsidan | Klick på passnamnet öppnar passets detaljsida | Rätt detaljsida öppnades | Godkänd | 2026-10-15 |
| Schemat bygger på registrerade pass | Passen hämtas från SQLite via EF Core | Schemat visade samma kommande pass som träningspasslistan | Godkänd | 2026-10-15 |

## Teknisk kontroll

| Test | Förväntat resultat | Faktiskt resultat | Resultat | Verifierat |
|---|---|---|---|---|
| `dotnet build` | Projektet bygger | 0 errors och 0 warnings | Godkänd | 2026-10-14 |
| `dotnet build` med schemasidan | Projektet bygger | 0 errors och 0 warnings | Godkänd | 2026-10-15 |

## Tester som återstår senare

De här testerna är inte gjorda än:

- Slutlig responsiv kontroll på mobil, surfplatta och dator.
