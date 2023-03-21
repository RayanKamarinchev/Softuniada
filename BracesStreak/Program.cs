string text = Console.ReadLine();
int maxStreak = 0;
int streak = 0;
bool open = false;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '(')
    {
        if (open)
        {
            streak=0;
        }
        else
        {
            open = true;
        }
    }

    if (text[i] == ')')
    {
        if (open)
        {
            streak++;
            open = false;
        }
        else
        {
            streak = 0;
        }
    }

    if (streak > maxStreak)
    {
        maxStreak = streak;
    }
}

Console.WriteLine(maxStreak*2);

//4 min