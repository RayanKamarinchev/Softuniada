List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> res = new List<int>();
int c = arr.Count;
if (arr.Count/2!=0)
{
    c--;
}
for (int i = 0; i < c; i+=2)
{
    if (arr[i] > arr[i+1])
    {
        res.Add(arr[i]);
        res.Add(arr[i+1]);
    }
    else
    {
        res.Add(arr[i + 1]);
        res.Add(arr[i]);
    }
}
if (arr.Count / 2 != 0)
{
    res.Add(arr.Last());
}

Console.WriteLine(string.Join(" ", res));

//30 min