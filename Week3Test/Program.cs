//programm küsib, mis hinde kasutaja sai
//kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
//'B', konsool kuvab "Väga hea!";
//'C', konsool kuvab "Hea!";
//'D', konsool kuvab "Rahuldav!";
//'E', konsool kuvab "Kasin!";
//'F', konsool kuvab "Puudulik!";
//kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

// kasutame SWITCH

Console.WriteLine("Mis hinde sa said:");

char hinne = Convert.ToChar(Console.ReadLine());

switch (hinne)
{
    case 'A':
        Console.WriteLine("Süürepärane!");
        break;
    case 'B':
        Console.WriteLine("Väga hea!");
        break;
    case 'C':
        Console.WriteLine("Hea!");
        break;
    case 'D':
        Console.WriteLine("Rahuldav!");
        break;
    case 'E':
        Console.WriteLine("Kasin!");
        break;
    case 'F':
        Console.WriteLine("Puudulik!");
        break;
    default:
        Console.WriteLine("Vale väärtus.");
        break;
}