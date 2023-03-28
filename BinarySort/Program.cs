int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
n--;
char[] res = new string('0', a + b).ToCharArray();
for (int i = 0; i < b; i++)
{
    decimal factor = 1m;
    int p = 0;
    while (n>=factor)
    {
        n -= (int)factor;
        factor *= (b + p) * 1.0m / (p+1);
        p++;
    }

    res[a - p+i] = '1';
    n++;
}

Console.WriteLine(res);