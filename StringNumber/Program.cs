List<string> nums = Console.ReadLine().Split(' ').ToList();
var orederable = nums.Select(n =>
{
    string b = n.TrimEnd('0');
    return new Tuple<string, bool>(b, b==n);
});
var sorted = orederable
             .Select((x, i) => new KeyValuePair<Tuple<string, bool>, int>(x, i))
             .OrderBy(x => x.Key.Item1)
             .ThenBy(x=>x.Key.Item2)
             .ThenBy(x=>x.Value)
             .ToList();
sorted.Reverse();
string res = "";
for (int i = 0; i < nums.Count; i++)
{
    res += nums[sorted[i].Value];
}

Console.WriteLine(res);

//20 min