# Checklista för betyget G – Core Gym Club Bokningssystem

Den här checklistan följer kraven för betyget Godkänt i projektet. Den visar
vad som är klart, vad som pågår och vad som återstår, samt var beviset för
varje krav finns. Senast genomgången 2026-10-16.

Statusvärden:

- **Klar** – kravet är uppfyllt och det finns bevis.
- **Delvis klar** – en del av kravet är uppfyllt, men något återstår.
- **Ej klar** – inget arbete gjort ännu.

## Checklista

| Krav | Status | Bevis / vad som återstår |
|---|---|---|
| 1. Minst 10 user stories | Klar | `docs/user-stories.md` innehåller 12 user stories med acceptanskriterier.<br>Samma stories finns som kort i Trello. |
| 2. Ett aktivitetsdiagram | Klar | Aktivitetsdiagram för flödet när en medlem bokar ett träningspass, skapat manuellt i Canva 2026-10-16.<br>Bild: `docs/images/AD.png`.<br>Visas i `docs/activity-diagram.md`. |
| 3. Ett sekvensdiagram | Klar | Sekvensdiagram för samma flöde, skapat manuellt i Canva 2026-10-16.<br>Bild: `docs/images/SD.png`.<br>Visas i `docs/sequence-diagram.md`. |
| 4. Agilt projektverktyg | Klar | Trello-board med listorna Backlog, To Do, In Progress, Testing och Done.<br>Alla 12 stories ligger i Done.<br>Status per story finns i `docs/user-stories.md`.<br>Screenshot av boarden med 12 av 12 i Done: `docs/images/screenshots/trello.png`. |
| 5. Git-brancher och pull requests | Klar | En feature-branch per funktion och PR #1 till PR #9.<br>PR #1 och #3–#9 är mergade. PR #2 (dokumentation) är öppen.<br>Branch, commit och PR för varje leverans finns i `docs/mvp-plan.md`.<br>Screenshots från projektet finns i `docs/images/screenshots/`. |
| 6. Körbar MVP varje vecka | Delvis klar | Körbara versioner kan styrkas med commits och PR:er för vecka 39, 40, 41 och 42. Se `docs/mvp-plan.md`.<br>Kan inte styrkas: det finns inga commits mellan 2026-09-23 och 2026-10-02, och inga leveranser före 2026-09-22. Om kursperioden omfattar fler veckor än 39–42 saknas bevis för dem. |
| 7. Löpande dokumentation dag för dag | Klar | `docs/daily-log.md` har ett daterat inlägg för varje arbetsdag: 2026-09-22, 2026-10-03, 2026-10-04, 2026-10-05, 2026-10-06, 2026-10-07, 2026-10-14, 2026-10-15 och 2026-10-16. |
| 8. Beslut och reflektioner | Klar | Beslut och Reflektion för varje dag i `docs/daily-log.md`.<br>Samlade beslut med motivering i `docs/decisions.md`. |
| 9. Responsiv webbapplikation | Klar | Bootstrap används i hela appen.<br>Adminlistan är mobilanpassad via PR #9, som är mergad till `main`.<br>Manuellt verifierat 2026-10-16: adminlistan fungerar i mobilvy utan horisontell sidscroll, med ett kort per pass och synliga knappar, och desktopvyn är oförändrad.<br>Testerna finns i `docs/test-checklist.md`. |
| 10. Utvecklingsteamets manifest | Klar | `docs/team-manifest.md`. |
| 11. Presentation | Ej klar | Återstår: förbereda och hålla presentationen. |
| 12. Slutligt inlämningsunderlag med bilder och bevis | Klar | Dokumentationen finns i `docs/`.<br>Diagrammen finns i `docs/images/AD.png` och `docs/images/SD.png`.<br>68 screenshots från projektet finns i `docs/images/screenshots/`. |

## Sammanfattning

- **Klara krav:** 1, 2, 3, 4, 5, 7, 8, 9, 10 och 12.
- **Delvis klara krav:** 6.
- **Ej klara krav:** 11.

Systemet är körbart på `main` med alla 12 user stories och en mobilanpassad
adminlista. Det som återstår är själva presentationen.
