# Projektdagbok – Core Gym Club Bokningssystem

Här dokumenterar jag mitt arbete dag för dag. Jag skriver bara in dagar där jag
faktiskt har arbetat med projektet, och jag fyller i dagboken samma dag som
arbetet görs.

## Mall

```
## Datum: ÅÅÅÅ-MM-DD

**Vad jag arbetade med:**

**Vad jag implementerade:**

**Beslut:**

**Problem:**

**Lösning:**

**Reflektion:**

**Nästa steg:**
```

---

## Datum: 2026-09-22 (tisdag)

**Vad jag arbetade med:**

Första riktiga arbetsdagen i projektet. Jag gick igenom uppgiften och kundens
krav för Core Gym Club, satte upp projektstrukturen och byggde den första
funktionen i systemet.

Konkret gjorde jag det här:

- Gick igenom kraven för uppgiften och kundens funktionskrav.
- Satte upp en Trello-board med listorna Backlog, To Do, In Progress, Testing
  och Done.
- Skrev 12 user stories med acceptanskriterier och lade in dem som kort i
  Trello.
- Skapade ASP.NET Core MVC-projektet `CoreGymBooking`.
- Skapade ett lokalt Git-repository och ett GitHub-repository
  (`AlidurBox/core-gym-booking`, privat).
- Skapade feature-branchen `feature/class-list` och byggde den första
  MVP-funktionen där besökare kan se kommande träningspass.
- Testade funktionen lokalt, commitade och öppnade PR #1.
- Flyttade upp korten i Trello för de user stories som funktionen täcker,
  efter att jag hade testat att den fungerade.

**Vad jag implementerade:**

En publik sida som listar kommande träningspass (`/Classes`).

- `Models/TrainingClass.cs` med titel, starttid, plats, instruktör, max antal
  deltagare och antal bokade. Lediga platser räknas ut i modellen som max antal
  minus antal bokade.
- `Data/TrainingClassSeed.cs` med fyra seedade träningspass. Listan filtrerar
  bort pass som redan har varit och sorterar på starttid, så att det alltid är
  kommande pass som visas.
- `Controllers/ClassesController.cs` som hämtar passen och skickar dem till
  vyn.
- `Views/Classes/Index.cshtml` som visar varje pass som ett kort med titel,
  datum, tid, plats, instruktör och lediga platser. Datum och tid skrivs ut på
  svenska, till exempel "onsdag 23 september 2026, 07:00".
- En enkel startsida med en knapp vidare till träningspassen, och en länk till
  träningspassen i menyn.

Verifiering: `dotnet build` gick igenom utan fel och utan varningar. Jag
startade projektet lokalt med `dotnet run`, och startsidan och sidan med
träningspass svarade båda som de skulle. Alla fyra seedade passen visades med
rätt uppgifter.

Commits på branchen så här långt:

- `bdf4e6e` Initial ASP.NET Core project setup (på `main`)
- `07a9981` Add public upcoming class list (på `feature/class-list`)

PR #1 "Add public upcoming class list" är öppen mot `main`.

**Beslut:**

- Jag valde ASP.NET Core MVC eftersom det är det vi arbetar med i kursen, och
  för att controllers och vyer är lätta att förklara muntligt.
- Jag körde på .NET 9, som redan fanns installerat på datorn.
- Jag kopplade inte på någon databas än. Träningspassen ligger tills vidare i
  en seed-klass i C#. Då kunde jag få upp en körbar sida direkt, och databasen
  tar jag i nästa steg när bokningarna ska sparas.
- Jag började med listan över träningspass eftersom den är kärnan i systemet.
  Registrering, inloggning och bokning bygger vidare på den.
- Sidan med träningspass är publik och kräver ingen inloggning, eftersom
  kunden vill att man ska kunna se schemat innan man blir medlem.
- Gränssnittet är på svenska, eftersom kunden är ett svenskt gym.

**Problem:**

Projektet skapades i en mapp som Codex hade lagt upp med dagens datum i
sökvägen. Det kändes osäkert att ha projektet liggande där, eftersom mappen är
kopplad till en session och kan försvinna.

**Lösning:**

Jag klonade ner GitHub-repot till min egen projektmapp `~/projekt` och arbetar
vidare därifrån. Eftersom allt redan var pushat låg ingenting kvar som bara
fanns lokalt i den gamla mappen. Framåt sköter jag kod, Git och dokumentation
från `~/projekt`, och Codex använder jag bara till Trello.

**Reflektion:**

Det kändes bra att få upp något körbart redan första dagen. Att börja med en
enkel seed-lista i stället för databas gjorde att jag snabbt kunde se något på
skärmen, och nu vet jag precis vilka fält ett träningspass behöver innan jag
lägger upp tabellerna.

Att dela upp arbetet i en egen branch med en pull request kändes ovant i
början, men det gör det tydligt vad varje del av arbetet innehåller. Jag
märker också att dokumentationen lätt hamnar sist, så jag ska försöka skriva
dagboken direkt efter varje arbetspass i stället för i efterhand.

**Nästa steg:**

- Lägga in projektdokumentationen i repot: user stories, aktivitetsdiagram,
  sekvensdiagram, beslut och den här dagboken.
- Föra över de 12 user stories som ligger i Trello till `docs/user-stories.md`,
  så att de finns både i projektverktyget och i repot.
- Granska och merga PR #1 till `main`.
- Koppla på databas med EF Core och SQLite, och flytta in träningspassen där.
- Efter det: registrering, inloggning och utloggning.

**Bevis att spara:**

- Screenshot på Trello-boarden med listorna och korten.
- Screenshot på branchlistan och commit-historiken i GitHub.
- Screenshot på PR #1.
