int n = int.Parse(Console.ReadLine());
string name = Console.ReadLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine(new String(' ', n) + "~ ~ ~");
}

Console.WriteLine(new String('=', 3*n+6));
for (int i = 0; i < n-2; i++)
{
    if (i==n/2-1)
    {
        Console.WriteLine("|" + new String('~', n) + name + new String('~', n) + "|");
    }
    else
    {
        Console.WriteLine("|" + new String('~', n*2+name.Length) + "|"+ new String(' ', n+3-name.Length) + "|");
    }
}
Console.WriteLine(new String('=', 3 * n + 6));
int a = 0;
for (int i = 2*n+4; i > 5; i-=2)
{
    Console.WriteLine(new String(' ', a) + "\\" + new String('@', i) + "/");
    a++;
}
Console.WriteLine(new String('-', 3 * n + 5));

//20min