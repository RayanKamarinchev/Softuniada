int n = int.Parse(Console.ReadLine());


for (int j = 0; j < n; j++)
{
    start:
    List<int> prices = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(p=>p).ToList();
    decimal avg = prices.Sum() / 3.0m;
    if (avg % 1 != 0)
    {
        Console.WriteLine("No");
    }
    else
    {
        for (int i = 0; i < 3; i++)
        {
            var ans = Greed(avg, prices);
            if (ans == null)
            {
                Console.WriteLine("No");
                j++;
                if (j==n)
                {
                    return;
                }
                goto start;
            }
            foreach (var an in ans)
            {
                prices[an] = 0;
            }

            prices.RemoveAll(p => p == 0);
        }
        Console.WriteLine("Yes");
    }
}

List<int> Greed(decimal avg, List<int> prices)
{
    int a = prices.Count;
    List<int> Search(int padding, int s, List<int> taken)
    {
        for (int j = s; j >= 0; j--)
        {
            if (taken.Contains(j))
            {
                continue;
            }
            if (padding - prices[j] == 0)
            {
                return taken.Append(j).ToList();
            }
            else if (padding - prices[j] > 0)
            {
                var res = Search(padding - prices[j], j - 1, taken.Append(j).ToList());
                if (res!=null)
                {
                    return res;
                }
            }
        }

        return null;
    }
    for (int i = 0; i < a; i++)
    {
        var res = Search((int)avg - prices[i], a-1, new List<int>(){i});
        if (res!=null)
        {
            return res;
        }
    }

    return null;
}
// 1h 30min