# MITTPP_Projekt

Alati korišteni za stvaranje okvira:

Katalon Recorder

Katalon Recorder je alat koji koristimo za kreiranje automatskih test skripti. Preteća ovog alata je
Selenium IDE Firefox extension.

Glavne značajke alata:
• Dostupan je kao Firefox/Chrome browser extension ili kao desktop aplikacija Katalon Studio
(usporedba)
• Snimanje testova putem record&play funkcionalnosti
• Snimanje UI testova koji simuliraju rad krajnjeg korisnika
• Koristan za brze korake i učenje automatizacije
• Spremanje i izvoz testa kao skripte u XML, WebDriver (C#, Java, Ruby, Python)
• Omogućava samostalno pisanje skripti bez korištenja snimalice ručnim unosom naredbi (sadrži
izbornik s objašnjenjima najčešće korištenih Selenium naredbi)
• Jednostavnije regresijsko testiranje prilikom implementacije nove funkcionalnosti
• Dodatna dokumentacija o alatu dostupna na Katalon stranici, uključujući primjer projekta

Katalon sve naredbe sprema u obliku HTML tabličnog formata

Visual Studio

Microsoft Visual Studio je okruženje (IDE) za razvoj softvera: računalnih programa, web stranica, web aplikacija, web servisa, i mobilnih aplikacija. Sadrži kompletiran set alata, potrebnih da se softver izradi od početka do kraja. Možemo kazati da je Visual Studio kompletirano rješenje za razvoj aplikacija iz već spomenutih kategorija.

Selenium WebDriver

Selenium WebDriver koristi naredbe snimljene putem Katalon alata i šalje ih pregledniku. Navedeni
proces je implementiran putem drivera za određeni preglednik, koji šalje naredbe preglednika, a
browser vraća rezultate. WebDriver izravno pokreće instancu preglednika i upravlja njime.

NUnit framework

NUnit je unit testing framework za Microsoft .NET. Samostalno ne kreira skripte za testiranje, ali
omogućava pokretanje Unit testova unutar Visual Studia.
Značajke:
• Testovi se mogu pokretati kroz konzolu ili putem Test Adaptera kroz Visual Studio
• Testovi se mogu paralelno izvršavati
• Svaki test se može dodati za jednu ili više kategorija, za selektivno pokretanje

Ključne riječi koje se definiraju unutar testa u Visual Studiu:
[SetUp] – pokretanje preglednika (Firefox, Chrome, Intern Explorer, Edge, Opera, Safari)
[TearDown]
[Test] – metoda koja sadrži test


Način korištenja

Za sve testne slučajeve koristi se Katalon Recorder na način da se prvo snimi test scenarij, a potom se pokrene snimak/skripta kako bi se provjerilo je li test prošao.
Nakon što se dobije skripta, moguće ju je izvesti u C# jeziku (ili bilo kojem drugom koji nam odgovara) i ta skripta će se koristiti u Visual Studio-u.

Pokretanjem Visual Studio-a potrebno je kreirati novi NUnit projekt za testiranje te skinuti potrebne driver-e kako bi testiranje bilo uspješno.

Putem Project -> Manage NuGet Packages dodati:
• Selenium WebDriver (4.6.0)
• Selenium Support(4.6.0)
• Selenium WebDriver – Gecko Driver (0.32.0) – izvođenje testa u Firefox-u

Nakon toga dodaje se test koji je prethodno eksportiran u format C# (WebDriver+Nunit) u UnitTest class.
Potrebno je provjeriti da klasa sadrži potrebne metode:
[SetUp]
[TearDown]
[Test]

te dopunimo test vlastitim varijablama, funkcijama, itd.

Uključi se Test Explorer: Test-> Windows-> Test Explorer
Gdje su testovi vidljivi nakon Build ->Build Solution
Pokrenu se testovi u Test Exploreru: Run tests


Test slučajevi 


Test ID:	1.1
Area of functionality:	Modul za registraciju korisnika
Objective:	Provjera funkcionalnosti registracije novog
korisnika u sustav
Test case results:	4 testnih točki: 4 Pass, 0 Fail
Note:	Korisnik prethodno nije registriran.

Test ID:	1.2
Area of functionality:	Modul za prijavu korisnika
Objective:	Provjera funkcionalnosti prijave korisnika u sustav
Test case results:	4 testnih točki: 4 Pass, 0 Fail
Note:	Korisnik je prethodno registriran.


Test ID: 	1.3
Area of functionality:	Modul za prijavu korisnika i shopping cart
Objective:	Provjera funkcionalnosti prijave korisnika i shopping carta
Test case results:	8 testnih točki:  Pass 8, 0 Fail
Note:	Korisnik je prethodno registriran.


Test ID: 	1.4
Area of functionality:	Modul za prijavu korisnika i dodavanja predmeta u whish list
Objective:	Provjera funkcionalnosti prijave korisnika i shopping carta
Test case results:	11 testnih točki:  Pass 11, 0 Fail
Note:	Korisnik je prethodno registriran.


Test ID: 	1.5
Area of functionality:	Modul za prijavu korisnika, dodavanje proizvoda u košaricu i brisanje iz nje
Objective:	Provjera funkcionalnosti prijave korisnika i shopping carta
Test case results:	10 testnih točki:  Pass 10, 0 Fail
Note:	Korisnik je prethodno registriran.
