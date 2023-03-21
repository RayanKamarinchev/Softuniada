int m = int.Parse(Console.ReadLine());
int[][] matrix = new int[m][];
for (int i = 0; i < m; i++)
{
    matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}
    
var diagonal = new bool[m, m];

for (var i = 0; i < m; i++)
{
    for (var j = 0; j < m; j++)
    {
        if (!diagonal[i, j] && !diagonal[j, i])
        {
            (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            diagonal[i, j] = true;
            diagonal[j, i] = true;
        }
    }
}
var flip = new bool[m, m];
for (var i = 0; i < m; i++)
{
    for (var j = 0; j < m; j++)
    {
        if (!flip[i, j] && !flip[i, m - j - 1])
        {
            (matrix[i][j], matrix[i][m - j - 1]) = (matrix[i][m - j - 1], matrix[i][j]);
            flip[i, j] = true;
            flip[i, m - j - 1] = true;
        }
    }
}

for (int i = 0; i < m; i++)
{
    Console.WriteLine(string.Join(' ', matrix[i]));
}

//4 min copied