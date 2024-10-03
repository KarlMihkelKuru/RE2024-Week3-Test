//programm küsib, mis hinde kasutaja sai
//kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
//'B', konsool kuvab "Väga hea!";
//'C', konsool kuvab "Hea!";
//'D', konsool kuvab "Rahuldav!";
//'E', konsool kuvab "Kasin!";
//'F', konsool kuvab "Puudulik!";
//kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

// kasutame IF

Console.WriteLine("Mis hinde sa said:");

char userGrade = Char.Parse(Console.ReadLine());

if (userGrade == 'A')
{
    Console.WriteLine("Süürepärane!");
}
else if (userGrade == 'B')
{
    Console.WriteLine("Väga hea!");
}
else if (userGrade == 'C')
{
    Console.WriteLine("Hea!");
}
else if (userGrade == 'D')
{
    Console.WriteLine("Rahuldav!");
}
else if (userGrade == 'E')
{
    Console.WriteLine("Kasin!");
}
else if (userGrade == 'F')
{
    Console.WriteLine("Puudulik!");
}
else
{
    Console.WriteLine("Vale väärtus.");
}