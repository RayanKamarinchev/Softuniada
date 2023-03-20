int n = int.Parse(Console.ReadLine());
List<int[]> matrix = new List<int[]>();
for (int i = 0; i < n; i++)
{
    matrix[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
}

List<int[]> basesAll = new List<int[]>();
for (int i = 0; i < n; i++)
{
    int h = matrix[i].Max();
    var bases = matrix[i].Where(s => s != h).ToArray();
    basesAll.Add(bases);
}



bool CanOrder(List<int[]> bases)
{
    basesAll.OrderBy(b => b[0])
        .ThenBy(b => b[1]);
    return true;
}
// 9:00