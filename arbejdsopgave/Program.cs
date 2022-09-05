using arbejdsopgave;

skoletaske Ataske = new();
madkasse Amadkasse=new madkasse();
mad spejsepølse=new mad();
Ataske.mad= Amadkasse;
spejsepølse.navn="sigurd";
Amadkasse.madliste.Add(spejsepølse);
Ataske.penalhus=new penalhus();
Ataske.penalhus.viskelæderliste = new();
Ataske.penalhus.viskelæderliste.Add(new viskelæder() { navn = "jordbær" });

foreach(viskelæder viskelæder in Ataske.penalhus.viskelæderliste)
{
    Console.WriteLine("viskelædder: " + viskelæder.navn);
}
foreach(mad mad in Ataske.mad.madliste)
{
    Console.WriteLine("mad: " + mad.navn);
}