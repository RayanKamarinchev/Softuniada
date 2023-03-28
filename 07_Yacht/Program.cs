Console.ReadLine();
var numsIn = Console.ReadLine().Split().Select(int.Parse).ToList();
int soFar = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
Console.WriteLine(Solve(numsIn, soFar));

int Solve(List<int> nums, int n)
{
    if (nums.Count == 0)
    {
        return n;
    }
    int add = nums[0];
    int maxRes = -1;
    nums.RemoveAt(0);
    if (n + add <= max)
    {
        maxRes = Math.Max(maxRes, Solve(nums, n + add));
    }
    if (n - add >= 0)
    {
        maxRes = Math.Max(maxRes, Solve(nums, n - add));
    }
    nums.Insert(0, add);

    return maxRes;
}