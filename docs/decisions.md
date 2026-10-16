# Beslut – Core Gym Club Bokningssystem

Här samlar jag de viktigaste besluten i projektet. Datumet visar när beslutet
togs. Mer om varje beslut finns i [projektdagboken](daily-log.md) för samma dag.

## Teknik

| Datum | Beslut | Varför |
|---|---|---|
| 2026-09-22 | ASP.NET Core MVC på .NET 9 | Det är det vi arbetar med i kursen, och controllers och vyer är lätta att förklara. .NET 9 fanns redan installerat. |
| 2026-09-22 | Gränssnittet är på svenska | Kunden är ett svenskt gym. |
| 2026-09-22 | Träningspassen låg först i en seed-klass i C# | Jag ville få upp en körbar sida direkt och vänta med databasen tills bokningar skulle sparas. |
| 2026-10-05 | SQLite och EF Core för träningspass och bokningar | En enkel lokal databas som inte kräver någon server, och som redan användes för användarkontona. |
| 2026-10-05 | `app.db` versionshanteras inte | Databasen är lokal testdata och skapas automatiskt via migrationer och seedning. |

## Funktioner

| Datum | Beslut | Varför |
|---|---|---|
| 2026-09-22 | Första MVP:n blev listan över kommande träningspass | Den är kärnan i systemet. Inloggning och bokning bygger vidare på den. |
| 2026-09-22 | Listan över träningspass är publik | Kunden vill att man ska kunna se passen innan man blir medlem. |
| 2026-10-05 | Bokning kräver inloggning | En bokning måste kopplas till en medlem. |
| 2026-10-05 | Unikt index på användare och pass i bokningstabellen | Dubbelbokning stoppas i databasen även om kontrollen i koden skulle missas. |
| 2026-10-07 | Personuppgifter sparas i en egen tabell, `UserProfiles` | En mindre ändring än att bygga om Identity-användaren. |
| 2026-10-07 | E-posten går inte att ändra på profilen | Den används för inloggning. |
| 2026-10-14 | Administrationen ligger i en egen controller med Admin-roll | Hela controllern kan skyddas med `[Authorize(Roles = "Admin")]`. |
| 2026-10-14 | En egen sida för nekad åtkomst | Att skicka inloggade medlemmar till inloggningssidan såg ut som ett fel. |
| 2026-10-14 | Adminkontot ligger i `appsettings.json` | Projektet går att klona och köra direkt. I ett riktigt projekt skulle uppgifterna ligga i user-secrets eller i en miljövariabel. |
| 2026-10-15 | Schemat blev en enkel översikt per dag, utan externt kalenderbibliotek | Det uppfyller acceptanskriterierna och håller projektet enkelt. |
| 2026-10-15 | Schemat återanvänder samma fråga för kommande pass som listan | Samma regel för vilka pass som räknas som kommande gäller då överallt. |
| 2026-10-16 | Adminlistan visas som kort på skärmar under 768px | Tabellen fick inte plats på mobil, och desktopversionen skulle inte ändras. |

## Arbetssätt

| Datum | Beslut | Varför |
|---|---|---|
| 2026-10-03 | Ett Trello-kort får ligga i Done först när alla acceptanskriterier är verifierade | Vid testning visade sig två kort i Done sakna kriterier. |
| 2026-10-03 | Allt Git-arbete går via feature-brancher och pull requests | Det blir tydligt vad varje del av arbetet innehåller. |
| 2026-10-04 | En komplettering får en egen pull request i stället för att ändra en mergad | PR #1 var redan mergad, så detaljsidan fick PR #3. |
| 2026-10-06 | Testresultat samlas i en egen testchecklista | Läraren ska kunna se vilka tester som faktiskt har gjorts. |

## Reflektioner

Reflektionerna skrivs för varje arbetsdag i [projektdagboken](daily-log.md),
under rubriken Reflektion. Det som har återkommit mest:

- Det räcker inte att en funktion ser klar ut. Först när acceptanskriterierna
  testas syns det om något saknas.
- När något verkar fel lönar det sig att först kolla vilken branch och vilken
  process som faktiskt kör, innan man letar fel i koden.
- Små brancher och pull requests gör det lätt att visa vad som gjordes och när.
