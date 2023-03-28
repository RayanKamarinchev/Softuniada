int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Dictionary<int, List<int>> connections = new Dictionary<int, List<int>>();
for (int i = 0; i < m; i++)
{
    var inp = Console.ReadLine().Split(" > ").Select(int.Parse).ToArray();
    if (!connections.ContainsKey(inp[0]))
    {
        connections.Add(inp[0], new List<int>());
    }
    connections[inp[0]].Add(inp[1]);
}

List<int> nums = Enumerable.Range(1, n).ToList();

int Solve(List<int> used)
{
    if (used.Count()==n)
    {
        return 1;
    }
    int res = 0;
    foreach (var i in nums.Where(n => ((connections.ContainsKey(n) && connections[n].All(c => used.Contains(c))) || !connections.ContainsKey(n))&& !used.Contains(n)))
    {
        used.Add(i);
        res+=Solve(used);
        used.Remove(i);
    }

    return res;
}

List<int> used = new List<int>();
Console.WriteLine(Solve(used));