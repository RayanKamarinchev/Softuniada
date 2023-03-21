int n = int.Parse(Console.ReadLine());
int[] connections = Enumerable.Repeat(-1, n).ToArray();
Tuple<int,int>[][] weightConnections = new Tuple<int, int>[n][];
int[] protConnections = new int[n];
for (int i = 0; i < n; i++)
{
    protConnections = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    weightConnections[i] = Enumerable.Repeat(new Tuple<int, int>(100, 100), n).ToArray();
    for (int j = protConnections.Length - 1; j >= 0; j--)
    {
        var tupl = weightConnections[i][protConnections[j]];
        weightConnections[i][protConnections[j]] = new Tuple<int, int>(j, tupl.Item2);
    }
}

int[] elConnections = new int[n];
for (int i = 0; i < n; i++)
{
    elConnections = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for (int j = elConnections.Length- 1; j >= 0; j--)
    {
        var tupl = weightConnections[elConnections[j]][i];
        weightConnections[elConnections[j]][i] = new Tuple<int, int>(tupl.Item1, j);
    }
}

var listedConnections = weightConnections.Select(c => c.ToList()).ToArray();
connections[0] = 0;
for (int i = 1; i < protConnections.Length; i++)
{
    listedConnections[i] = listedConnections[i].Select((c, i) =>
    {
        if (connections.Contains(i))
        {
            return new Tuple<int, int>(0, 0);
        }

        return c;
    }).ToList();
    var max = listedConnections[i].IndexOf(listedConnections[i].Min());
    connections[i] = max;
}

for (int i = 0; i < connections.Length; i++)
{
    Console.WriteLine($"{i} <-> {connections[i]}");
}

//1h 10min