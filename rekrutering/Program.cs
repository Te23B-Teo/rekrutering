List<string> names = ["calle", "anna", "joakim", "lukas", "elis", "anders", "julia", "nora", "harald", "sara"];
bool någon = false;
int valet = 0;
List<string> vilkanamn = [];

while (true)
{
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine("person " + i + ":" + names[i]);
    }
    Console.WriteLine($"Välj vem du vill ha i ditt lag skriv 0-{names.Count - 1}");
    string val = Console.ReadLine();

    någon = int.TryParse(val, out valet);

    if (någon == false || valet > names.Count || valet < 0)
    {
        Console.Clear();
        Console.WriteLine("det där var inte ett alternativ");
        continue;
    }
    else
    {
        vilkanamn.Add(names[valet]);
        names.RemoveAt(valet);


        for (int l = 0; l < vilkanamn.Count; l++)
        {
            Console.WriteLine(vilkanamn[l]);
        }
        Console.ReadLine();
    }
}


// List<string> names = ["micke", "martin", "lena", "karim", "liv"];
// for (int i = 0; i < names.Count; i++){
//     Console.WriteLine(names[i]);
// }


// names.Add("nicholas");
// names.Remove("lena");
// names.RemoveAt(3);
// names[0] = "mikael";

// int i = Random.Shared.Next(3);
// Console.WriteLine(names[i]);
// Thread.Sleep(200);