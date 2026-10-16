# MVP-leveranser

Här listas de körbara versioner som faktiskt går att visa i Git-historiken. Varje
version byggdes i en egen branch, och varje leverans har en commit och en pull
request. Datumen kommer från commitarna och pull requestarna på GitHub.

## Översikt per vecka

| Vecka | Datum | Körbara leveranser |
|---|---|---|
| 39 | 2026-09-22 | MVP 1: lista över kommande träningspass (PR #1) |
| 40 | 2026-10-03 – 2026-10-04 | PR #1 mergad till `main`, detaljsida för träningspass (PR #3) |
| 41 | 2026-10-05 – 2026-10-07 | Användarhantering (PR #4), bokning (PR #5), profil och avbokning (PR #6) |
| 42 | 2026-10-14 – 2026-10-16 | Administration (PR #7), schema (PR #8), mobilanpassad adminlista (PR #9) |

Det finns minst en körbar version varje vecka från projektstarten vecka 39
till och med vecka 42.

Det här kan **inte** styrkas:

- Mellan 2026-09-23 och 2026-10-02 finns inga commits. Leveransen för vecka 40
  kom först 2026-10-03 – 2026-10-04.
- Det finns inga leveranser före 2026-09-22. Om kursperioden började tidigare
  finns det inget bevis för de veckorna.

## Milstolpar

### MVP 1 – Kommande träningspass (vecka 39)

- **Datum:** 2026-09-22
- **Funktioner:** publik lista över kommande träningspass med titel, datum,
  tid, plats, instruktör och lediga platser. Passen låg i en seed-klass.
- **Git:** `feature/class-list`, commit `07a9981 Add public upcoming class list`,
  PR #1 (skapad 2026-09-22, mergad 2026-10-03)
- **Körbar:** `dotnet build` utan fel och varningar, och sidan startades med
  `dotnet run` och testades lokalt.
- **Bevis:** PR #1, commit `07a9981`, dagboken 2026-09-22, testchecklistan.

### Detaljsida (vecka 40)

- **Datum:** 2026-10-04
- **Funktioner:** varje träningspass går att öppna och har en detaljsida med
  beskrivning och lediga platser. Okänt pass ger 404.
- **Git:** `feature/class-details`, commit `2cd8cf0 Add training class details`,
  PR #3
- **Körbar:** MVP 1 testades igen 2026-10-03 innan PR #1 mergades.
  Detaljsidan testades manuellt i webbläsaren innan PR #3 mergades.
- **Bevis:** PR #1 och PR #3, dagboken 2026-10-03 och 2026-10-04,
  testchecklistan.

### Användarhantering (vecka 41)

- **Datum:** 2026-10-05
- **Funktioner:** registrering, inloggning, utloggning och skyddad profilsida.
- **Git:** `feature/authentication`, commit `d54a2bb Add user authentication`,
  PR #4
- **Körbar:** registrering, fel lösenord, inloggning, skyddad sida och
  utloggning testades i webbläsaren.
- **Bevis:** PR #4, dagboken 2026-10-05, testchecklistan.

### Bokning (vecka 41)

- **Datum:** 2026-10-05
- **Funktioner:** bokning av pass, Mina bokningar, spärr mot dubbelbokning och
  fullbokat pass. Träningspassen flyttades till SQLite via EF Core.
- **Git:** `feature/booking`, commit `442888c Add training class booking`, PR #5
- **Körbar:** bokning, lediga platser (16 till 15), dubbelbokning och fullbokat
  pass testades i webbläsaren.
- **Bevis:** PR #5, dagboken 2026-10-05, testchecklistan.

### Profil och avbokning (vecka 41)

- **Datum:** 2026-10-07
- **Funktioner:** ändra namn och telefonnummer, Mina bokningar och avbokning.
- **Git:** `feature/profile-and-cancellation`, commit
  `4c3aebf Add profile management and booking cancellation`, PR #6
- **Körbar:** profiländring, avbokning och lediga platser (15 till 16) testades
  i webbläsaren.
- **Bevis:** PR #6, dagboken 2026-10-07, testchecklistan.

### Administration (vecka 42)

- **Datum:** 2026-10-14
- **Funktioner:** admin kan skapa, redigera och ta bort träningspass. Vanliga
  medlemmar nekas åtkomst.
- **Git:** `feature/admin-classes`, commit
  `d77084d Add training class administration`, PR #7
- **Körbar:** alla adminflöden och nekad åtkomst testades i webbläsaren, och
  `dotnet build` gav 0 errors och 0 warnings.
- **Bevis:** PR #7, dagboken 2026-10-14, testchecklistan.

### Schema (vecka 42)

- **Datum:** 2026-10-15
- **Funktioner:** publik schemasida där kommande pass grupperas per datum och
  sorteras efter tid.
- **Git:** `feature/class-schedule`, commit `afc55ba Add training class schedule`,
  PR #8
- **Körbar:** schemasidan testades i webbläsaren med två pass samma dag, och
  `dotnet build` gav 0 errors och 0 warnings.
- **Bevis:** PR #8, dagboken 2026-10-15, testchecklistan.

### Mobilanpassad adminlista (vecka 42)

- **Datum:** 2026-10-16
- **Funktioner:** adminlistan visas som kort på skärmar under 768px.
- **Git:** `feature/admin-mobile-responsive`, commit
  `9206455 Improve admin mobile layout`, PR #9
- **Körbar:** `dotnet build` gav 0 errors och 0 warnings.
- **Manuellt verifierat 2026-10-16:** adminlistan fungerar i mobilvy utan
  horisontell sidscroll, varje pass visas som ett kort, Redigera och Ta bort
  syns, och desktopvyn är oförändrad.
- **Status:** PR #9 mergades till `main` 2026-10-16.
- **Bevis:** PR #9, dagboken 2026-10-16, testchecklistan.
