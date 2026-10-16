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

---

## Datum: 2026-10-05 (måndag)

**Vad jag arbetade med:**

En lång arbetsdag med två stories. Först blev användarhanteringen klar och
mergad, sedan byggde jag bokningsfunktionen.

Användarhantering:

- Verifierade och färdigställde registrering, inloggning och utloggning.
- Testade registrering och att bekräftelsen visas.
- Testade fel lösenord och att felmeddelandet visas.
- Testade inloggning med rätt uppgifter.
- Testade att den skyddade profilsidan kräver inloggning.
- Testade utloggning, och att en utloggad användare skickas till
  inloggningssidan.
- Flyttade de två auth-storysen till Done med 4/4 kriterier.
- Commitade, skapade PR #4 och mergade den till `main`.

Bokning av träningspass:

- Började på storyn "Boka träningspass".
- Skapade `Booking`-modellen med relation till `TrainingClass`.
- Flyttade träningspassen från den enkla seed-listan till SQLite med EF Core.
- Skapade migrationen `AddTrainingClassesAndBookings`.
- Testade bokning manuellt i webbläsaren.
- Testade att lediga platser minskade från 16 till 15 efter bokningen.
- Testade att bokningen visas under Mina bokningar.
- Testade dubbelbokning och fullbokat pass.
- Flyttade "Boka träningspass" till Done med 5/5 kriterier.
- Commitade, skapade PR #5 och mergade den till `main`.

**Vad jag implementerade:**

- `Booking` med Id, UserId, TrainingClassId och CreatedAt, kopplad till den
  inloggade Identity-användaren och till träningspasset.
- Träningspassen ligger nu i databasen i stället för i en hårdkodad lista, och
  seedas automatiskt om tabellen är tom.
- Lediga platser räknas som maxantal minus antalet sparade bokningar, och kan
  aldrig visas som ett negativt tal.
- Dubbelbokning blockeras, både av en kontroll i koden och av ett unikt index i
  databasen.
- Fullbokade pass blockeras, och användaren får ett tydligt meddelande.
- Bokningen sparas i SQLite, och Mina bokningar på profilsidan visar
  användarens kommande bokningar med titel, datum och tid.

**Beslut:**

- SQLite och EF Core används nu även för träningspass och bokningar, inte bara
  för användare.
- Ett unikt index läggs på UserId och TrainingClassId, så att dubbelbokning
  stoppas även om kontrollen i koden skulle missas.
- Den lokala databasfilen `app.db` ska inte versionshanteras, utan ligger i
  `.gitignore`.
- Avbokning implementeras senare, i en egen story.
- Storyn "Se profil och mina bokningar" markeras inte som klar ännu, även om
  profilsidan nu visar bokningar. Den har fler egna kriterier.

**Problem:**

Den lokala databasfilen hade tidigare råkat tas bort under en kontroll av
Git-reglerna, så testanvändaren försvann.

Jag märkte också igen hur stor skillnaden är mellan ett tekniskt test och en
riktig verifiering i webbläsaren. Ett pass kan svara med rätt statuskod utan
att sidan känns rätt att använda.

**Lösning:**

Databasen var inget problem i sig, eftersom den återskapas automatiskt via
migrationen och seedningen vid nästa start. Jag fick bara registrera en ny
testanvändare.

För att inte flytta kort i onödan testar jag varje acceptanskriterium i
webbläsaren innan ett Trello-kort får flyttas till Done.

**Reflektion:**

Projektet har nu riktig användarhantering och riktiga bokningar i en databas,
vilket känns som ett stort steg från den första listan med hårdkodade pass.

Brancher, pull requests och Trello speglar också arbetet bättre nu. Varje
story har sin egen branch och sin egen pull request, vilket gör det lätt att
visa vad som gjorts och när.

**Nästa steg:**

- Avbokning av ett bokat pass.
- Därefter adminfunktionerna för att skapa, redigera och ta bort pass.

**Bevis att samla in:**

- PR #4 och PR #5 efter merge.
- Trello med de fem storysen i Done och ifyllda checklistor.
- Skärmbild på bekräftelsen efter en bokning.
- Skärmbild på meddelandet vid dubbelbokning och på ett fullbokat pass.
- Skärmbild på Mina bokningar.

---

## Datum: 2026-10-06 (tisdag)

**Vad jag arbetade med:**

En kontroll- och dokumentationsdag. Bokningsfunktionen var redan klar och
mergad, så i dag handlade arbetet om att kontrollera att allt verkligen ligger
på plats och att samla bevisen för de tester jag har gjort.

- Kontrollerade att PR #4 och PR #5 är mergade till `main`.
- Kontrollerade att användarhanteringen och bokningen finns på `origin/main`.
- Kontrollerade Trello-statusen i dokumentationen.
- Verifierade att fem stories ligger i Done och sju i Backlog.
- Sammanställde tidigare genomförda tester i `docs/test-checklist.md`.
- Kontrollerade vilka G-krav som återstår.

**Vad jag implementerade:**

Ingen ny kod i dag. Arbetet var kontroll och dokumentation.

**Beslut:**

- Jag bygger inte om bokningsfunktionen, eftersom den redan är klar, verifierad
  och mergad.
- Testresultaten samlas i en egen checklista i stället för att bara ligga
  utspridda i dagboken.
- PR #2 fortsätter vara öppen, så att den löpande dokumentationen kan samlas
  där.

**Problem:**

GitHub hade återigen fel aktivt konto, så den första `git fetch` misslyckades
med "Repository not found".

**Lösning:**

Jag växlade tillbaka till kontot AlidurBox, och därefter gick det att verifiera
både repot och `main`.

**Reflektion:**

Det räcker inte med att koden fungerar. Läraren behöver också kunna se vilka
tester som faktiskt har gjorts, och då hjälper en samlad testchecklista.
Bokningsflödet är nu implementerat, manuellt verifierat och dokumenterat, och
det känns som en tydlig helhet.

**Nästa steg:**

- Avboka träningspass.

**Bevis att samla in:**

- Trello med fem stories i Done.
- PR #4 och PR #5 i mergat läge.
- Testchecklistan i repot.

---

## Datum: 2026-10-07 (onsdag)

**Vad jag arbetade med:**

Jag tog tre stories på en gång, eftersom de hänger ihop och alla handlar om
profilsidan: "Ändra personuppgifter", "Se profil och mina bokningar" och
"Avboka träningspass".

- Skapade `UserProfile` med namn och telefonnummer, kopplad till
  Identity-användaren.
- Skapade `ProfileViewModel`.
- Skapade migrationen `AddUserProfiles`.
- Uppdaterade profilsidan så att e-post, namn och telefonnummer visas.
- Lade till ett formulär för att ändra namn och telefonnummer.
- Personuppgifterna sparas i SQLite via EF Core.
- Kommande bokningar visas under Mina bokningar.
- Lade till en Avboka-knapp för varje bokning.

**Vad jag implementerade:**

- Avbokningen sker med POST och kräver inloggning.
- Användaren kan bara avboka sina egna bokningar. Bokningen hämtas med både
  bokningens id och den inloggade användarens id.
- Bokningen tas bort ur databasen.
- Lediga platser ökar automatiskt efter avbokning, eftersom antalet räknas från
  sparade bokningar.
- En bekräftelse visas efter avbokningen, med namnet på passet.

Manuellt verifierat i webbläsaren:

- Profilen visade e-post, namn och telefonnummer.
- Namnet ändrades till "Alidur Hamid Test".
- Telefonnumret ändrades och sparades.
- Bekräftelsen "Dina personuppgifter är sparade." visades.
- Core och balans fanns under Mina bokningar.
- Avbokningen fungerade.
- Bekräftelsen "Din bokning av Core och balans har avbokats." visades.
- Bokningen försvann från Mina bokningar.
- Lediga platser ökade från 15 till 16.

Git:

- Branch `feature/profile-and-cancellation`.
- Commit `4c3aebf`.
- PR #6, som mergades till `main`.

Trello efter dagens arbete:

- Ändra personuppgifter, Done 4/4.
- Se profil och mina bokningar, Done 4/4.
- Avboka träningspass, Done 4/4.
- Få bekräftelse på bokning och avbokning, Done 3/3.
- Totalt 9 i Done och 3 i Backlog.

**Beslut:**

- De tre profilrelaterade storysen togs i samma branch, eftersom de delar samma
  sida och samma controller.
- Personuppgifterna sparas i en egen tabell `UserProfiles` i stället för att
  bygga om Identity-användaren, vilket blev en mindre ändring.
- E-posten visas men går inte att ändra, eftersom den används för inloggning.

**Problem:**

Först visade `localhost:5067` den ursprungliga ASP.NET-mallen i stället för
Core Gym Club. Det berodde på att en gammal dotnet-process låg kvar och
körde kod som byggts när dokumentationsbranchen var utcheckad.

Pushen till GitHub misslyckades också flera gånger, först med "Internal Server
Error" och sedan med "Repository not found".

**Lösning:**

Jag startade om rätt process från `~/projekt` med rätt branch utcheckad, och
då visades appen korrekt.

Pushproblemet berodde på att det aktiva GitHub-kontot hade växlat. Jag
växlade tillbaka till AlidurBox, och därefter fungerade både push och PR.

**Reflektion:**

Det är viktigt att kontrollera vilken branch och vilken process som faktiskt
kör, innan man letar efter fel i koden. Felet låg inte i projektet utan i
miljön.

Att verifiera manuellt innan ett Trello-kort flyttas till Done fungerar bra, och
nu har projektet ett komplett grundflöde för medlemmen: konto, profil, bokning
och avbokning.

**Nästa steg:**

- Admin kan skapa träningspass.
- Admin kan redigera och ta bort träningspass.

**Bevis att samla in:**

- Trello med nio stories i Done.
- PR #6 före och efter merge.
- Skärmbild på profilsidan med e-post, namn och telefonnummer.
- Skärmbild på bekräftelsen efter avbokning.

---

## Datum: 2026-10-14 (onsdag)

**Vad jag arbetade med:**

Adminfunktionerna blev klara, verifierade och mergade till `main`.

- Gick igenom adminfunktionerna i webbläsaren och testade dem punkt för punkt
  mot acceptanskriterierna.
- Testade att skapa ett träningspass, att redigera det och att ta bort det.
- Testade att en vanlig medlem nekas åtkomst till administrationen.
- Körde `dotnet build`, som gav 0 errors och 0 warnings.
- Commitade arbetet som `d77084d Add training class administration` på
  branchen `feature/admin-classes`.
- Skapade PR #7 "Add training class administration" och mergade den till
  `main`.
- Flyttade de två adminkorten till Done i Trello och uppdaterade
  dokumentationen.

**Vad leveransen innehåller:**

- **Adminroll och behörighetskontroll:** rollen Admin och ett lokalt adminkonto
  skapas när appen startar. Administrationen ligger bakom
  `[Authorize(Roles = "Admin")]`, och adminlänken i menyn visas bara för
  administratörer.
- **Skapa träningspass:** ett formulär med titel, beskrivning, datum och tid,
  plats, instruktör och max antal deltagare. Passet sparas i SQLite via EF Core
  och syns direkt i den vanliga träningspasslistan.
- **Redigera träningspass:** adminsidan listar alla pass, och varje pass kan
  öppnas och ändras. Ändringarna syns både på adminsidan och i listan och på
  detaljsidan.
- **Ta bort träningspass:** varje pass kan tas bort, och det försvinner då från
  både administrationen och den vanliga listan.
- **Validering:** alla fält valideras med svenska felmeddelanden, och ett
  ogiltigt formulär sparar ingenting.
- **Vanlig medlem nekas:** direkta adresser och POST mot administrationen ger
  sidan "Ingen behörighet", och ett pass som inte finns ger 404.

Trello efter dagens arbete:

- Admin kan skapa träningspass, Done 5/5.
- Admin kan redigera och ta bort träningspass, Done 4/4.
- Totalt 11 i Done och 1 i Backlog. Kvar är bara storyn om schema eller
  kalenderöversikt.

**Beslut:**

- Administrationen fick en egen controller och egna vyer, i stället för att
  blandas in i den vanliga passlistan. Det gör behörighetskontrollen enkel,
  eftersom hela controllern kan skyddas med en rad.
- Adminkontots uppgifter ligger i `appsettings.json`, så att projektet går att
  klona och köra direkt. I ett riktigt projekt skulle de ligga i user-secrets
  eller i en miljövariabel.
- En egen sida för nekad åtkomst, i stället för att skicka inloggade medlemmar
  tillbaka till inloggningssidan, vilket såg ut som ett fel.

**Problem:**

Pushen till GitHub nekades igen, eftersom det aktiva GitHub-kontot hade växlat
till ett annat av mina konton.

**Lösning:**

Jag växlade tillbaka till AlidurBox, och då fungerade både push och pull
request. Det här har hänt flera gånger nu, så nästa steg är att lägga in
kontonamnet i remote-adressen för det här repot.

**Reflektion:**

Nu finns hela grundflödet som kunden efterfrågade: medlemmen kan registrera
sig, logga in, se passen, boka, avboka och sköta sin profil, och
administratören kan sköta schemat. Det känns som att projektet uppfyller
funktionskraven för G.

Behörighetskontrollen var enklare än jag trodde. En rad på controllern räckte,
men det var viktigt att faktiskt testa med ett vanligt medlemskonto och med
direkta adresser, och inte bara lita på att adminlänken var dold.

**Nästa steg:**

- Aktivitetsdiagram och sekvensdiagram för bokningsflödet.
- Uppdatera README inför inlämning.

**Bevis att samla in:**

- Trello med 11 stories i Done.
- PR #7 före och efter merge.
- Skärmbild på adminsidan med listan över pass.
- Skärmbild på formuläret för att skapa eller redigera ett pass.
- Skärmbild på sidan "Ingen behörighet" när en vanlig medlem försöker nå
  administrationen.

---

## Datum: 2026-10-15 (torsdag)

**Vad jag arbetade med:**

Den sista user storyn, "Se träningspass i schema eller kalenderöversikt", blev
klar, verifierad och mergad till `main`. Därmed ligger alla 12 stories i Done.

- Skapade branchen `feature/class-schedule` från `main` efter PR #7.
- Byggde en schemasida för kommande träningspass.
- Verifierade sidan manuellt i webbläsaren mot acceptanskriterierna.
- Körde `dotnet build`, som gav 0 errors och 0 warnings.
- Commitade arbetet som `afc55ba Add training class schedule`.
- Skapade PR #8 "Add training class schedule" och mergade den till `main`.
- Flyttade storyn till Done i Trello och uppdaterade dokumentationen.

**Vad jag implementerade:**

- **Publik schemasida:** `/Classes/Schedule` kräver ingen inloggning och nås
  via länken "Schema" i menyn.
- **Kommande träningspass:** bara pass som inte har startat visas.
- **Gruppering per datum:** passen grupperas under en rubrik för varje dag.
- **Sortering:** passen sorteras efter datum och tid.
- **Innehåll:** varje pass visar tid, titel, plats och instruktör.
- **Länkar:** passets namn länkar till den befintliga detaljsidan.
- **Data:** passen hämtas från SQLite via EF Core, med samma fråga för
  kommande pass som den vanliga träningspasslistan använder.

Manuellt verifierat i webbläsaren:

- Schemasidan gick att öppna utan inloggning.
- Bara kommande pass visades, grupperade per datum.
- Två pass samma dag visades under samma datum och i rätt tidsordning.
- Tid, titel, plats och instruktör visades för varje pass.
- Passnamnet ledde till rätt detaljsida.

Git:

- Branch `feature/class-schedule`.
- Commit `afc55ba Add training class schedule`.
- PR #8 "Add training class schedule", som mergades till `main`.

Trello efter dagens arbete:

- Se träningspass i schema eller kalenderöversikt, Done 4/4.
- Totalt 12 av 12 stories i Done.

**Beslut:**

- Schemat blev en egen sida i `ClassesController` i stället för en ny
  controller, eftersom det visar samma data som träningspasslistan.
- Schemasidan återanvänder den befintliga frågan för kommande pass. Då gäller
  samma regel för vilka pass som räknas som kommande i både listan och
  schemat.
- Jag valde en översikt grupperad per dag i stället för en hel
  kalenderkomponent. Det uppfyller acceptanskriterierna utan något externt
  bibliotek.
- Sidan är publik, precis som träningspasslistan, så att man kan se schemat
  innan man blir medlem.

**Problem:**

Det aktiva GitHub-kontot var återigen ett annat av mina konton, så repot syntes
inte från terminalen.

**Lösning:**

Push och pull request gjordes med kontot AlidurBox. Remote-adressen är
fortfarande inte ändrad, så problemet kan komma tillbaka.

**Reflektion:**

Alla 12 user stories är nu klara och verifierade, och funktionskraven för
systemet är uppfyllda. Det var bra att testa med två pass samma dag. Med bara
ett pass per dag hade sorteringen inom en dag inte gått att kontrollera.

**Nästa steg:**

- Aktivitetsdiagram och sekvensdiagram för bokningsflödet.
- Utvecklingsteamets manifest.
- Slutlig responsiv kontroll och uppdaterad README inför inlämning.
- Slutpresentation.

**Bevis att samla in:**

- Trello med 12 av 12 stories i Done.
- PR #8 före och efter merge.
- Skärmbild på schemasidan med två pass samma dag.

---

## Datum: 2026-10-16 (fredag)

**Vad jag arbetade med:**

Jag gjorde projektets aktivitetsdiagram och sekvensdiagram. Båda visar flödet
när en medlem bokar ett träningspass.

- Skapade aktivitetsdiagrammet manuellt i Canva och exporterade det som
  `AD.png`.
- Skapade sekvensdiagrammet manuellt i Canva och exporterade det som
  `SD.png`.
- Lade till `docs/activity-diagram.md` och `docs/sequence-diagram.md`, som
  visar diagrammen i repot.
- Uppdaterade G-checklistan, där kraven på aktivitetsdiagram och
  sekvensdiagram nu är klara.

Senare under dagen:

- Upptäckte att adminlistan inte fungerade på mobil, och gjorde den
  mobilanpassad på branchen `feature/admin-mobile-responsive`.
- Commitade ändringen som `9206455 Improve admin mobile layout` och skapade
  PR #9.
- Testade adminlistan manuellt i mobilvy och på desktop, och mergade sedan
  PR #9 till `main`.
- Gick igenom alla G-krav mot Git-historiken och dokumentationen.
- Uppdaterade README så att den beskriver det färdiga systemet.
- Skapade `docs/team-manifest.md`, `docs/decisions.md` och `docs/mvp-plan.md`.

**Vad jag implementerade:**

Diagrammen och dokumentationen ovan, och en mobilanpassad adminlista. På
skärmar under 768px visas varje träningspass som ett kort i stället för en
tabellrad. Desktoptabellen och funktionerna för att redigera och ta bort är
oförändrade. `dotnet build` gav 0 errors och 0 warnings.

**Beslut:**

- Båda diagrammen beskriver bokningsflödet, eftersom det är systemets
  viktigaste flöde och berör både medlem, inloggning och databas.
- Diagrammen gjordes manuellt i Canva.
- Bilderna ligger i `docs/images/` och visas via en egen markdownfil för varje
  diagram, så att de går att se direkt på GitHub.
- Adminlistan visas som kort på mobil i stället för en tabell som går att
  scrolla i sidled, eftersom det inte syntes att tabellen gick att scrolla.
- I MVP-dokumentationen tar jag bara med leveranser som kan visas med commits
  och pull requests.

**Problem:**

På mobil gick tabellen på sidan "Administrera träningspass" utanför skärmen,
och kolumnerna till höger syntes inte.

**Lösning:**

Tabellen låg redan i Bootstraps `table-responsive`, men det syntes inte att den
gick att scrolla. Under 768px visas därför varje rad som ett kort med etikett
och värde, med hjälp av CSS. Ändringen ligger i PR #9.

Manuellt verifierat 2026-10-16:

- Adminlistan fungerar i mobilvy utan horisontell sidscroll.
- Varje träningspass visas som ett kort.
- Knapparna Redigera och Ta bort syns.
- Desktopvyn är oförändrad och fungerar som en vanlig tabell.

Därefter mergades PR #9 till `main`.

**Korrigering av inlägget 2026-10-15:**

Inlägget för 2026-10-15 räknar upp mer som manuellt verifierat än vad som
faktiskt testades i webbläsaren.

- Manuellt verifierat: schemasidan visar passen grupperade per datum, två pass
  samma dag visas i rätt tidsordning, och passnamnet leder till detaljsidan.
- Tekniskt verifierat, inte manuellt: att sidan går att öppna utan inloggning
  (anrop utan inloggning gav svar 200, 2026-10-16) och att bara kommande pass
  visas (kontrollerat i koden).

**Reflektion:**

Det var lättare att rita diagrammen nu, när bokningsfunktionen redan är byggd
och testad, eftersom flödet gick att följa i den riktiga koden i stället för
att gissa.

**Nästa steg:**

- Ta screenshots av Trello, GitHub och appen.
- Sammanställa inlämningsdokumentet.
- Slutpresentation.

**Bevis att samla in:**

- Aktivitetsdiagrammet och sekvensdiagrammet i repot.
- G-checklistan efter genomgången av alla krav.
- PR #9 före och efter merge.
- Adminlistan på mobil och på desktop.
