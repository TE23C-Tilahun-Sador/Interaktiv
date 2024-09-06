using System.Threading.Tasks.Dataflow;

Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();
name = name.ToLower();

if (name == "sador" || name == "zen" || name == "micke")
{
    Console.WriteLine($"Välkommen! {name}");
}
else
{
    Console.WriteLine($"Nämen fan. Välkommen i guess {name}");
}

Console.ReadLine();

Console.WriteLine("Skriv (starta) för att börja berättelsen: ");
string starta = "";
while (starta != "starta" && starta != "" )
{
    starta = Console.ReadLine();
    starta = starta.ToLower();
}


if (starta.ToLower() == "starta")
{
    Console.Clear();
    Console.WriteLine("Klockan är halv tolv på kvällen");
    Console.WriteLine("Du är påväg hem från träningen");
    Console.WriteLine("Din mobil vibrerar i din ficka och du tar upp den för att se vem som skrev");
    Console.WriteLine($""" "Kom hem snabbt det börjar bli sent {name}!!! Flera kidnappningar har skett på sistone" Skriver Morsan """);
    Console.WriteLine("Du svarar din mamma med ett okej och lägger telefonen medans du suckar ");
    Console.WriteLine("Du går längs en bil väg och ser hur en svartskåp bil saktar ner vid dig ");
    Console.WriteLine("PLÖTSLIGT så öppnar sido dörrarna upp ");
    Console.WriteLine("En maskerad man lägger en påse över ditt huvud och kastar in dig i skåpbilen");
    Console.WriteLine("*Du blir nedsövd*");
}
else
{
    Console.WriteLine("Klicka på (Enter) för att avsluta spelet: ");
}
Console.ReadLine();

Console.Clear();
Console.WriteLine("Du vaknar upp i skåpbilen och ser maskerade mannen som kidnappade dig bredvid dig");
Console.WriteLine("När du kollar ut genom bil fönstret ser du att ni kör på en skogsväg");
Console.WriteLine("Du märker även att bildörren närmst dig är öppen ");
Console.WriteLine("");
Console.WriteLine("Hoppar du ut från bilen eller inte(Ja eller Nej): ");

string HoppaUt = "";
while (HoppaUt != "ja" && HoppaUt != "nej")
{
    HoppaUt = Console.ReadLine();
    HoppaUt = HoppaUt.ToLower();
}

if (HoppaUt == "ja")
{
    Console.Clear();
    Console.WriteLine("Du öppnar dörren och ser att ni kör fort");
    Console.WriteLine("Med ingen tid för att tänka, gör du ditt hastiga beslut och hoppar ut från bilen");
    Console.WriteLine("Du landar i en buske och sekunden du kan ställa dig upp så springen du rakt in i skogen");
    Console.WriteLine("");
    Console.WriteLine(" *30 minuter efter* ");
    Console.WriteLine("");
    Console.WriteLine("Utan att ha saktat ner tempot så har du sprungit hela vägen fram till en bilväg ");
    Console.WriteLine("Du hör en murrande ljud åt din vänster");
    Console.WriteLine("När du kollar dit så ser du två billyktor ");
    Console.WriteLine("");
    Console.WriteLine("Du har ett val");
    Console.WriteLine("Gömmer du dig för bilen(Ja eller nej: )");

    string Gömma = Console.ReadLine();
    Gömma = Gömma.ToLower();

    if (Gömma == "ja")
    {
        Console.Clear();
        Console.WriteLine("Du gömmer dig för bilen");
        Console.WriteLine("Samma svarta skåpbil som kidnappade dig susar förbi");
        Console.WriteLine("Du känner en lättnad");
        Console.WriteLine("Med ingenstans du kan vägen och en huvudvärk från sömnmedlet så går du längs vägen");
        Console.WriteLine("Då ser du plötsligt två billyktor till");
        Console.WriteLine("Du gömmer dig bakom en buske men bilen verkade redan ha sett dig ");
        Console.WriteLine("Den stoppar vid busken och en man går ut");
        Console.WriteLine("Då ser du hans uniform");
        Console.WriteLine("Det är en polis");
        Console.WriteLine("Nu så vet du att du är säker ");
        Console.WriteLine("du springer upp till polisen och säger allt som har hänt ");
        Console.WriteLine("Han kör dig sedan till polisstationen där du får träffa din mamma ");
        Console.WriteLine("");
        Console.WriteLine("Du har vunnit");
        Console.WriteLine("Klicka på (Enter) för att avsluta spelet: ");
        Console.ReadLine();

    }

    else
    {
        Console.Clear();
        Console.WriteLine("Maskerade mannen hoppar ut ur skåpbilen och slår till dig medvetslös");
        Console.WriteLine("");
        Console.WriteLine(" *En timme efter* ");
        Console.WriteLine("");
        Console.WriteLine("Du vaknar upp av iskallt vatten som hälls över dig");
        Console.WriteLine("Du tittar runt och ser dig fastbunden på ett operationsbord i ett rum med massor av blodiga verktyg");
        Console.WriteLine("På din högra sida så ser du en man och i handen har han en såg");
        Console.WriteLine("");
        Console.WriteLine("GAME OVER (Klicka på enter för att avsluta spelet): ");
        Console.ReadLine();
    }

}
else
{
    Console.Clear();
    Console.WriteLine("Maskerade mannen ser att du är vaken och slår till dig medvetslös");
    Console.WriteLine("");
    Console.WriteLine(" *En timme efter* ");
    Console.WriteLine("");
    Console.WriteLine("Du vaknar upp av iskallt vatten som hälls över dig");
    Console.WriteLine("Du tittar runt och ser dig fastbunden på ett operationsbord i ett rum med massor av blodiga verktyg");
    Console.WriteLine("På din högra sida så ser du en man och i handen har han en såg");
    Console.WriteLine("");
    Console.WriteLine("GAME OVER (Klicka på enter för att avsluta spelet): ");
    Console.ReadLine();
}
