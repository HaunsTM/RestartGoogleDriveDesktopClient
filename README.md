<h1>Restart Google Drive Desktop Client</h1>

<p>En console-applikation skriven i C# att för att starta om en Windows-service.</p>

<p>Google Drive är en molntjänst vars desktopklient har benägenhet att krascha och sluta fungera. Klientens huvuduppgift är att sköta synkronisering mellan ett lokalt filrepository och ett dito molnlagrat. Kraschnbenägenheten är hög när stora filer ofta ändras.</p>

<p>Applikationens exefil ska anropas periodiskt via Windows Scheduler givet den frekvens med vilken man vill starta om sin Google Drive-client.</p>
