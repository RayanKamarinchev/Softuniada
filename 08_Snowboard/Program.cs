int n = int.Parse(Console.ReadLine());
var pathNames = Console.ReadLine().Split().ToArray();
var costs = Console.ReadLine().Split().Select(int.Parse).ToArray();
var reward = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<SnowPath> paths = new List<SnowPath>();
for (int i = 0; i < pathNames.Length; i++)
{
    paths.Add(new SnowPath(pathNames[i], costs[i], reward[i]));
}

List<SnowPath> used = new List<SnowPath>();

paths = paths.OrderByDescending(p => p.Importance)
             .ThenByDescending(p=>p.Cost).ToList();
foreach (var path in paths)
{
    if (n>=path.Cost)
    {
        n -= path.Cost;
        used.Add(path);
    }
}

Console.WriteLine(string.Join(' ', used.Select(u => u.Name).ToArray()));
Console.WriteLine($"{used.Select(u => u.Importance * u.Cost).Sum():f0}");
Console.WriteLine(n);

class SnowPath
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public decimal Importance { get; set; }

    public SnowPath(string name, int cost, int reward)
    {
        Name = name;
        Cost = cost;
        Importance = reward * 1.0m / cost;
    }
}