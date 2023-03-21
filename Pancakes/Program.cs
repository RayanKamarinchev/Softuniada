using System;
class GFG
{
    static int[] maxSubArraySum(int[] a)
    {
        int size = a.Length;
        int max_so_far = int.MinValue, max_ending_here = 0, max_seq = 0;
        int start = 0;
        int maxStart = 0;
        int end = 0;

        for (int i = 0; i < size; i++)
        {
            max_ending_here += a[i];

            if (max_so_far < max_ending_here || (max_so_far == max_ending_here && max_seq<i-start))
            {
                max_so_far = max_ending_here;
                end = i;
                maxStart = start;
                max_seq = end - start;
            }


            if (max_ending_here < 0)
            {
                max_ending_here = 0;
                start = i+1;
            }
        }

        return new[] { max_so_far, maxStart, end };
    }

    // Driver code
    public static void Main()
    {
        int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write(string.Join(' ', maxSubArraySum(a)));
    }
}

//27 min