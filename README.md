# Core Gym Club Bokningssystem

Ett bokningssystem för gymmet Core Gym Club. Medlemmar kan se och boka
träningspass, och en administratör kan sköta passen.

## Funktioner

- Registrering av nytt konto
- Inloggning och utloggning
- Lista över kommande träningspass
- Detaljsida för varje pass med beskrivning och lediga platser
- Boka och avboka träningspass
- Profilsida med personuppgifter och egna bokningar
- Administration där admin kan skapa, redigera och ta bort pass
- Schemaöversikt där kommande pass visas dag för dag
- Responsiv design med Bootstrap

## Teknik

- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- SQLite
- ASP.NET Core Identity för konton, inloggning och adminroll

## Köra projektet lokalt

Krav:

- .NET SDK 9

Bygg projektet:

```bash
dotnet build
```

Starta applikationen:

```bash
dotnet run --project src/CoreGymBooking/CoreGymBooking.csproj
```

Öppna sedan adressen som visas i terminalen, till exempel
`http://localhost:5067`.

Databasen `app.db` skapas automatiskt vid första starten. Några träningspass
läggs in som exempeldata.

### Adminkonto för lokal testning

Ett adminkonto skapas automatiskt utifrån inställningen `AdminAccount` i
`appsettings.json`.

Kontot är bara tänkt för lokal testning.

## Dokumentation

Projektdokumentationen ligger i mappen [docs](docs):

- [User stories](docs/user-stories.md)
- [Projektdagbok](docs/daily-log.md)
- [Beslut](docs/decisions.md)
- [MVP-leveranser](docs/mvp-plan.md)
- [Aktivitetsdiagram](docs/activity-diagram.md)
- [Sekvensdiagram](docs/sequence-diagram.md)
- [Testchecklista](docs/test-checklist.md)
- [Utvecklingsteamets manifest](docs/team-manifest.md)
- [Checklista för G](docs/g-requirements-checklist.md)
