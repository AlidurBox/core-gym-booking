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
- Tog fram 12 user stories med acceptanskriterier och lade in dem i Trello via
  Trello API. Codex användes för API-anropen och för att skapa korten och
  checklistorna utifrån projektets planering.
- Skapade ASP.NET Core MVC-projektet `CoreGymBooking`.
- Skapade ett lokalt Git-repository och ett GitHub-repository
  (`AlidurBox/core-gym-booking`, privat).
- Skapade feature-branchen `feature/class-list` och byggde den första
  MVP-funktionen där besökare kan se kommande träningspass.
- Testade funktionen lokalt, commitade och öppnade PR #1.
- Flyttade de två user stories som klasslistan täcker till Done i Trello efter
  att funktionen hade testats.

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

Projektet låg först i en tillfällig arbetsmapp. Jag ville flytta arbetet till
en permanent lokal projektmapp som jag själv hade kontroll över.

**Lösning:**

Jag klonade GitHub-repot till `~/projekt` och fortsatte arbetet därifrån. Kod,
Git och dokumentation hanteras där, medan Trello används som projektverktyg.

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

**Bevis att samla in:**

- Screenshot på Trello-boarden med listorna och korten.
- Screenshot på branchlistan och commit-historiken i GitHub.
- Screenshot på PR #1.

---

## Datum: 2026-10-03 (lördag)

**Vad jag arbetade med:**

En genomgångs- och kontrolldag. Jag stämde av projektets nuläge mot G-kraven,
kontrollerade Trello och Git, och testade den befintliga MVP-versionen innan
jag mergade den.

- Gick igenom projektets nuläge och G-kraven.
- Kontrollerade Trello-boarden med de 12 user storysen.
- Tog screenshots av Trello, GitHub-brancherna och pull requestarna.
- Verifierade `feature/class-list` lokalt.
- Körde `dotnet build` och kontrollerade att projektet byggde.
- Startade applikationen och verifierade sidan med träningspass.
- Kontrollerade PR #1 och PR #2.
- Mergade PR #1 till `main`.
- Granskade och förbättrade den befintliga projektloggen.

**Vad jag implementerade:**

Ingen ny större funktion under huvuddelen av dagen. Arbetet gick i stället ut
på att verifiera det som redan fanns. Den befintliga MVP-versionen testades
och visade kommande träningspass med plats, instruktör och lediga platser.

**Beslut:**

- Dokumentationen ska bara beskriva arbete som faktiskt har genomförts.
- Screenshots som tas nu ska inte presenteras som gamla screenshots.
- User storysen i dokumentationen ska motsvara de befintliga Trello-korten och
  deras acceptanskriterier.
- Allt Git-arbete ska gå via feature-brancher och pull requests.

**Problem:**

Git mot GitHub gav först felet "Repository not found", trots att repot fanns.
Det visade sig att fel GitHub-konto var aktivt.

Vid den manuella testningen upptäckte jag dessutom att två stories som låg i
Done inte uppfyllde alla sina acceptanskriterier. Träningspassen gick inte att
öppna, och passets beskrivning visades inte.

**Lösning:**

Jag aktiverade GitHub-kontot AlidurBox för projektet, och då fungerade push
igen.

De två berörda Trello-korten fick behandlas som pågående igen, tills
kriterierna kunde verifieras. Jag planerade en kodändring med klickbara pass
och en detaljsida.

**Reflektion:**

Det var viktigt att faktiskt testa acceptanskriterierna och inte bara lita på
att ett Trello-kort låg i Done. Git- och Trello-bevisen blev också tydligare
när varje steg verifierades innan merge. Jag behöver fortsätta kontrollera att
dokumentationen, Trello och den faktiska funktionen stämmer överens.

**Nästa steg:**

- Färdigställa detaljsidan för träningspass.
- Verifiera de två saknade acceptanskriterierna.
- Fortsätta med projektdokumentationen.

**Bevis att samla in:**

- Trello-boarden.
- Branchlistan i GitHub.
- PR #1 före och efter merge.
- Den körbara sidan med träningspass.
- Terminalbild med branch, commit och lyckad build.

---

## Datum: 2026-10-04 (söndag)

**Vad jag arbetade med:**

Jag byggde klart detaljsidan, verifierade de två kriterierna som hade fallerat
och fick in kompletteringen i `main`. Sedan fortsatte jag med dokumentationen.

- Färdigställde och testade detaljsidan för träningspass.
- Verifierade de två tidigare saknade acceptanskriterierna manuellt i
  webbläsaren.
- Uppdaterade Trello, så att de två verifierade storysen kunde ligga i Done
  igen.
- Skapade branchen `feature/class-details`.
- Commitade och pushade kodändringen.
- Skapade PR #3 och granskade den innan merge.
- Mergade PR #3 till `main`.
- Tog fram och verifierade `docs/user-stories.md` utifrån de 12 befintliga
  Trello-korten.
- Återställde och verifierade `docs/user-stories.md`.
- Skapade `docs/g-requirements-checklist.md`.

**Vad jag implementerade:**

- `TrainingClass` fick fälten `Id` och `Description`.
- Varje träningspass i listan går nu att öppna.
- En ny detaljsida visar titel, beskrivning, datum, tid, plats, instruktör och
  lediga platser.
- Ett okänt pass-id ger 404.
- Den befintliga klasslistan fungerar som tidigare.

**Beslut:**

- PR #1 skulle inte ändras efter att den var mergad. Kompletteringen fick en
  egen branch och en egen pull request, PR #3.
- Bara de fem berörda kodfilerna fick ingå i kodcommiten.
- `docs/user-stories.md` skulle ligga separat på dokumentationsbranchen.
- Ett Trello-kort får ligga i Done först när samtliga acceptanskriterier är
  verifierade.

**Problem:**

En gammal instans av applikationen körde fortfarande på port 5067 och visade
därför den gamla koden, vilket gjorde testningen missvisande.

`docs/user-stories.md` låg dessutom tillfälligt i en stash när branchen
byttes, så filen syntes inte i arbetsmappen.

**Lösning:**

Den nya versionen verifierades separat, och därefter testade jag den manuellt i
webbläsaren. Stashen återställdes på `docs/project-documentation`, och jag
kontrollerade att filen var komplett.

**Reflektion:**

Jag såg tydligt varför Testing-steget behövs. Funktionen såg färdig ut, men
två kriterier saknades tills jag faktiskt testade dem. En separat pull request
för kompletteringen gjorde dessutom Git-historiken tydligare. G-checklistan
gör det lättare att se vilka krav som är klara och vilka som återstår.

**Nästa steg:**

- Registrering, inloggning och utloggning.
- Fortsätta leverera nya körbara versioner.
- Senare aktivitetsdiagram och sekvensdiagram.
- Fortsätta den löpande dokumentationen.

**Bevis att samla in:**

- Screenshot på detaljsidan för Morgonstyrka.
- Trello med de två storysen i Done och fullständiga checklistor.
- PR #3 före merge.
- PR #3 efter merge.
- G-checklistan och user storysen i repot.
