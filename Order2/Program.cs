//int n = int.Parse(Console.ReadLine());
//List<int> ordered = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

//List<int> players = new List<int>(ordered);
//ordered = ordered.OrderBy(p => p).ToList();
//List<int> one = new List<int>();
//one.Add(0);
//List<int> two = new List<int>();
//two.Add(int.MaxValue);
//int left = 0;

//for (int i = 0; i < players.Count; i++)
//{
//    var oneValid = ordered.Where(n => n > one.Last()).ToList();
//    int oneIndx = oneValid.IndexOf(players[i]);
//    var twoValid = ordered.Where(n => n < two.Last()).ToList();
//    int twoIndx = twoValid.IndexOf(players[i]);
//    if (twoIndx == -1)
//    {
//        twoIndx = int.MinValue;
//        if (oneIndx == -1)
//        {
//            left++;
//            ordered.Remove(players[i]);
//            continue;
//        }
//    }
//    if (oneIndx > 1 || twoValid.Count - twoIndx - 1 <= 1)
//    {
//        if (twoValid.Count - twoIndx - 1 > 1)
//        {
//            left++;
//        }
//        else
//        {
//            two.Add(players[i]);
//        }
//    }
//    else
//    {
//        one.Add(players[i]);
//    }
//    ordered.Remove(players[i]);
//}

//Console.WriteLine(left);
static int Solve(int n, int index, int whiteIndex, int blackIndex, int[,,] dp, int[] elements)
{
    if (index == n)
    {
        return 0;
    }

    if (dp[index, whiteIndex, blackIndex] != 0)
    {
        return dp[index, whiteIndex, blackIndex];
    }

    int secondaryState = 0;
    int tertiaryState = 0;

    if (whiteIndex == n || elements[index] > elements[whiteIndex])
    {
        secondaryState = 1 + Solve(n, index + 1, index, blackIndex, dp, elements);
    }

    if (blackIndex == n || elements[index] < elements[blackIndex])
    {
        tertiaryState = 1 + Solve(n, index + 1, whiteIndex, index, dp, elements);
    }

    dp[index, whiteIndex, blackIndex] = Math.Max(Solve(n, index + 1, whiteIndex, blackIndex, dp, elements), Math.Max(secondaryState, tertiaryState));

    return dp[index, whiteIndex, blackIndex];
}

int n = int.Parse(Console.ReadLine());

int[,,] dp = new int[257, 257, 257];

string[] unparsed = Console.ReadLine().Split(' ');
int[] parsed = new int[n];

for (int i = 0; i < unparsed.Length; i++)
{
    parsed[i] = int.Parse(unparsed[i]);
}

Console.WriteLine(n - Solve(n, 0, n, n, dp, parsed));