# Checklista för betyget G – Core Gym Club Bokningssystem

Den här checklistan följer kraven för betyget Godkänt i projektet. Den visar
vad som är klart, vad som pågår och vad som återstår, samt var beviset för
varje krav finns.

Statusvärden:

- **Klar** – kravet är uppfyllt och det finns bevis.
- **Pågår** – arbetet är påbörjat men inte färdigt.
- **Ej klar** – inget arbete gjort ännu.

## Checklista

| Krav | Status | Bevis / vad som återstår |
|---|---|---|
| 1. Minst 10 relevanta user stories | Klar | `docs/user-stories.md` innehåller 12 user stories.<br>Alla har acceptanskriterier.<br>Samma stories finns som kort i Trello. |
| 2. Minst ett aktivitetsdiagram | Ej klar | Inget ännu. Ska göras för flödet när en medlem bokar ett träningspass. |
| 3. Minst ett sekvensdiagram | Ej klar | Inget ännu. Ska göras för samma flöde, alltså medlem bokar träningspass. |
| 4. Använda agilt projektverktyg | Klar | Trello-board med listorna Backlog, To Do, In Progress, Testing och Done.<br>12 user stories ligger som kort.<br>Screenshots har tagits.<br>Elva verifierade stories ligger i Done och en i Backlog. |
| 5. Git med egna branches och pull requests | Klar | Brancher: `feature/class-list`, `feature/class-details`, `feature/authentication`, `feature/booking`, `feature/profile-and-cancellation`, `feature/admin-classes` och `docs/project-documentation`.<br>PR #1 mergad.<br>PR #3 mergad.<br>PR #4 mergad.<br>PR #5 mergad.<br>PR #6 mergad.<br>PR #7 mergad.<br>PR #2 fortfarande öppen för dokumentationen.<br>Screenshots finns från brancher och pull requests. |
| 6. Leverera körbar MVP eller version regelbundet | Pågår | Första körbara versionen visade en lista över kommande träningspass.<br>Senare verifierad komplettering med klickbara träningspass och en detaljsida.<br>MVP 2 med användarhantering är mergad till `main` via PR #4.<br>Bokningsversionen är mergad till `main` via PR #5.<br>Profilhantering och avbokning är mergade till `main` via PR #6.<br>Administration av träningspass är mergad till `main` via PR #7.<br>Build och körbar app har verifierats för varje version.<br>Återstår: fortsätta leverera körbara versioner under resten av projektet, så att kravet på regelbundna leveranser kan visas i sin helhet. |
| 7. Löpande projektdokumentation | Pågår | `docs/daily-log.md`, `docs/user-stories.md` och `docs/test-checklist.md`.<br>Dokumentationen är uppdaterad till och med 2026-10-14.<br>Beslut, problem, lösningar och reflektioner dokumenteras.<br>Återstår: fortsätta fylla på för varje arbetsdag fram till inlämning. |
| 8. Beslut och reflektioner | Pågår | Finns i `docs/daily-log.md` under rubrikerna Beslut och Reflektion.<br>Återstår: fortsätta dokumentera beslut och reflektioner under projektet. |
| 9. Utvecklingsteamets manifest | Ej klar | Inget ännu. |
| 10. Slutpresentation | Ej klar | Inget ännu. |
| 11. Körbar slutversion | Pågår | Fungerar i dag: startsida, lista över kommande träningspass med titel, datum, tid, plats, instruktör och lediga platser, klickbara träningspass, detaljsida med beskrivning och passinformation, registrering, inloggning, utloggning, skyddad profilsida, bokning av träningspass, bokningar som sparas i databasen, Mina bokningar, spärr mot dubbelbokning, spärr mot fullbokat pass, dynamiskt antal lediga platser, profilhantering med namn och telefonnummer, avbokning av bokade pass samt administration där admin kan skapa, redigera och ta bort träningspass med behörighetskontroll.<br>Genomförda tester finns i `docs/test-checklist.md`, inklusive profil, avbokning och administration.<br>Återstår: slutlig responsiv kontroll och en uppdaterad README inför inlämning. Storyn om schema eller kalenderöversikt ligger kvar i Backlog som framtida funktion. |

## Sammanfattning

- **Klara krav:** 1, 4 och 5.
- **Pågående krav:** 6, 7, 8 och 11.
- **Ej påbörjade krav:** 2, 3, 9 och 10.

Närmast i tur står aktivitetsdiagrammet och sekvensdiagrammet, eftersom de är
egna krav och inte beror på att mer kod blir klar.
