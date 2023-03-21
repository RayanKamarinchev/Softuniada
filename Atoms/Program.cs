int n = int.Parse(Console.ReadLine());
int[] connections = new int[n];
int[][] weightConnections = new int[n][];
int[] protConnections = new int[n];
for (int i = 0; i < n; i++)
{
    protConnections = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    weightConnections[i] = Enumerable.Repeat(-1, n).ToArray();
    for (int j = protConnections.Length - 1; j >= 0; j--)
    {
        weightConnections[i][protConnections[j]] += j;
    }
}

int[] elConnections = new int[n];
for (int i = 0; i < n; i++)
{
    elConnections = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for (int j = elConnections.Length-1; j >= 0; j--)
    {
        weightConnections[elConnections[j]][i]+=j;
    }
}

var listedConnections = weightConnections.Select(c => c.ToList()).ToArray();
for (int i = 0; i < protConnections.Length; i++)
{
    listedConnections[i].Where((c,i) => connections.Contains(i)).Select(c=>c=0);
    int indx = listedConnections[i].IndexOf(listedConnections[i].Max());
    connections[i] = indx;
}

for (int i = 0; i < connections.Length; i++)
{
    Console.WriteLine($"{i} <-> {connections[i]}");
}

//40min