int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
for (int i = 0; i < n; i++)
{
    var els = Console.ReadLine().Split().ToArray();
    if (!output.ContainsKey(els[0]))
    {
        output[els[0]] = new List<string>();
    }
    output[els[0]].Add(els[1]);

    if (!output.ContainsKey(els[1]))
    {
        output[els[1]] = new List<string>();
    }
    output[els[1]].Add(els[0]);
}

foreach (var key in output.OrderBy(k=>k.Key))
{
    foreach (var list in key.Value)
    {
        Console.WriteLine($"{key.Key} <-> {list}");
    }
}