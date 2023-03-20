int c = int.Parse(Console.ReadLine());
int r = int.Parse(Console.ReadLine());
List<int>[] matrix = new List<int>[c];
List<int> res = new List<int>();
for (int i = 0; i < c; i++)
{
    matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
}

for (int i = 0; i < c; i++)
{
    if (i>=r)
    {
        Console.WriteLine(string.Join(" ", res));
        return;
    }
    for (int j = i; j < r; j++)
    {
        res.Add(matrix[i][j]);
    }
    if (i+1 >= c)
    {
        Console.WriteLine(string.Join(" ", res));
        return;
    }

    for (int j = i+1; j < c; j++)
    {
        res.Add(matrix[j][r-1]);
    }
    if (r-2 < i)
    {
        Console.WriteLine(string.Join(" ", res));
        return;
    }

    for (int j = r-2; j >= i; j--)
    {
        res.Add(matrix[c-i-1][j]);
    }
    if (c-2 <= i)
    {
        Console.WriteLine(string.Join(" ", res));
        return;
    }

    for (int j = c-2; j > i; j--)
    {
        res.Add(matrix[j][i]);
    }

    r--;
    c--;
}
//47min