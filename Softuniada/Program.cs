static int GCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
            a %= b;
        else
            b %= a;
    }

    return a | b;
}

static int findLCM(int a, int b) //method for finding LCM with parameters a and b
{
    int num1, num2;                         //taking input from user by using num1 and num2 variables
    if (a > b)
    {
        num1 = a; num2 = b;
    }
    else
    {
        num1 = b; num2 = a;
    }

    for (int i = 1; i <= num2; i++)
    {
        if ((num1 * i) % num2 == 0)
        {
            return i * num1;
        }
    }
    return num2;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(GCD(a,b) + findLCM(a,b));