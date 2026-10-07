# User stories – Core Gym Club Bokningssystem

Det här är de user stories som styr arbetet med Core Gym Club
Bokningssystem. De används för att planera utvecklingen och för att följa
hur långt projektet har kommit. Varje story beskriver en funktion sett ur
användarens perspektiv och har egna acceptanskriterier, som visar när
funktionen räknas som klar.

Samma user stories ligger som kort i projektets Trello-board, där varje kort
har acceptanskriterierna som checklista. Under varje story nedan står vilken
lista kortet ligger i.

## Status i Trello

**Done:**

- Registrera användarkonto
- Logga in och logga ut
- Ändra personuppgifter
- Se profil och mina bokningar
- Se kommande träningspass
- Se information och lediga platser för ett pass
- Boka träningspass
- Avboka träningspass
- Få bekräftelse på bokning och avbokning

**Backlog:**

- Admin kan skapa träningspass
- Admin kan redigera och ta bort träningspass
- Se träningspass i schema eller kalenderöversikt

## User stories

### 1. Registrera användarkonto

Som medlem vill jag kunna registrera ett konto med e post och lösenord så att jag kan använda bokningssystemet och boka träningspass.

Trello-lista: Done

Acceptanskriterier:

- Användaren kan ange e post och lösenord
- Ett nytt konto kan skapas
- Användaren får bekräftelse när registreringen lyckas
- Användaren kan därefter logga in

### 2. Logga in och logga ut

Som medlem vill jag kunna logga in och logga ut så att jag kan komma åt mitt konto och använda bokningssystemet på ett säkert sätt.

Trello-lista: Done

Acceptanskriterier:

- Användaren kan logga in med e post och lösenord
- Felaktiga inloggningsuppgifter ger ett felmeddelande
- Inloggad användare kan logga ut
- Utloggad användare kommer inte åt funktioner som kräver inloggning

### 3. Ändra personuppgifter

Som medlem vill jag kunna ändra mina personuppgifter så att informationen på mitt konto är aktuell.

Trello-lista: Done

Acceptanskriterier:

- Användaren kan öppna sin profil
- Användaren kan ändra sina personuppgifter
- Ändringarna kan sparas
- Den uppdaterade informationen visas på profilen

### 4. Se profil och mina bokningar

Som medlem vill jag kunna se min profil och mina kommande bokningar så att jag får en tydlig överblick över mitt konto.

Trello-lista: Done

Acceptanskriterier:

- Användaren kan öppna sin profilsida
- Profilen visar användarens uppgifter
- Kommande bokningar visas
- Varje bokning visar vilket träningspass som är bokat

### 5. Se kommande träningspass

Som medlem vill jag kunna se kommande träningspass så att jag kan välja vilket pass jag vill delta i.

Trello-lista: Done

Acceptanskriterier:

- Kommande träningspass visas i en lista
- Tidigare träningspass visas inte som kommande
- Varje pass går att öppna för mer information

### 6. Se information och lediga platser för ett pass

Som medlem vill jag kunna se information och antal lediga platser för ett träningspass så att jag kan avgöra om jag vill boka det.

Trello-lista: Done

Acceptanskriterier:

- Passets titel visas
- Datum och tid visas
- Plats och instruktör visas
- Antal lediga platser visas
- Passets beskrivning visas

### 7. Boka träningspass

Som medlem vill jag kunna boka ett träningspass så att jag kan delta på passet.

Trello-lista: Done

Acceptanskriterier:

- En inloggad medlem kan boka ett pass
- Bokning kan endast göras om det finns en ledig plats
- Bokningen sparas
- Det bokade passet visas bland användarens bokningar
- Samma medlem kan inte boka samma pass flera gånger

### 8. Avboka träningspass

Som medlem vill jag kunna avboka ett träningspass så att min plats blir tillgänglig för någon annan.

Trello-lista: Done

Acceptanskriterier:

- Användaren kan se sina bokningar
- En befintlig bokning kan avbokas
- Den avbokade bokningen tas bort från användarens kommande bokningar
- En plats blir åter tillgänglig på träningspasset

### 9. Få bekräftelse på bokning och avbokning

Som medlem vill jag få en bekräftelse när jag bokar eller avbokar så att jag vet att åtgärden lyckades.

Trello-lista: Done

Acceptanskriterier:

- En bekräftelse visas efter genomförd bokning
- En bekräftelse visas efter genomförd avbokning
- Bekräftelsen visar vilken åtgärd som genomfördes

### 10. Admin kan skapa träningspass

Som administratör vill jag kunna skapa träningspass så att nya pass kan läggas till i schemat.

Trello-lista: Backlog

Acceptanskriterier:

- Administratören kan öppna ett formulär för att skapa ett pass
- Titel och beskrivning kan anges
- Datum, tid, plats och instruktör kan anges
- Maximalt antal deltagare kan anges
- Det skapade passet visas bland träningspassen

### 11. Admin kan redigera och ta bort träningspass

Som administratör vill jag kunna redigera och ta bort träningspass så att schemat kan hållas uppdaterat.

Trello-lista: Backlog

Acceptanskriterier:

- Administratören kan öppna ett befintligt träningspass
- Information om passet kan ändras och sparas
- Administratören kan ta bort ett träningspass
- Ändringar visas i schemat

### 12. Se träningspass i schema eller kalenderöversikt

Som medlem vill jag kunna se träningspassen i en schema eller kalenderöversikt så att jag enkelt kan få en överblick över kommande pass.

Trello-lista: Backlog

Acceptanskriterier:

- Kommande träningspass visas i en tydlig översikt
- Datum och tid framgår
- Användaren kan se vilket pass som ligger på respektive datum
- Översikten använder information från de registrerade träningspassen
