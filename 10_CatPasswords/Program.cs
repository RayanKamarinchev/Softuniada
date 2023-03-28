using System.Numerics;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

int fact(int n)
{
    if (n == 0)
        return 1;
    return n * fact(n - 1) % 1000000007;
}

BigInteger Pow(int n, int times)
{
    BigInteger re = BigInteger.One;
    for (int i = 0; i < times; i++)
    {
        re *= n;
    }

    return re;
}

BigInteger res=1;
BigInteger final = 0;
int left = a - b - c - d;
for (int i = 0; i <= left; i++)
{
    for (int j = 0; j <= left - i; j++)
    {
        res *= fact(a);
        res /= fact(b+left-i-j);
        res /= fact(c+i);
        res /= fact(d+j);
        if (b+left-i-j != 0)
        {
            res *= Pow(10, b+left-i-j);
        }
        if (c+i != 0)
        {
            res *= Pow(30, c+i);
        }
        if (d+j != 0)
        {
            res *= Pow(30, d+j);
        }

        final += res;
        res = 1;
    }
}
final %= 1000000007;
Console.WriteLine(final);