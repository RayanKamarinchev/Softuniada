long n = long.Parse(Console.ReadLine());
List<long> res = new List<long>();
res.Add(1);
for (long i = 0; i < n/2; i++)
{
    res.Add((n-i)*res.Last()/(i+1));
}

var mock = res.ToArray().ToList();
if (n%2==0)
{
    mock.RemoveAt(mock.Count-1);
}
res.Reverse();
mock.AddRange(res);
Console.WriteLine(string.Join(" ", mock));

//10 min