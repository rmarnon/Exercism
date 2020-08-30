using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private static List<int> Score { get; set; } = new List<int>();

    public HighScores(List<int> list)
    {
        Score = list;
    }

    public List<int> Scores() => Score;

    public int Latest() => Score.Last();

    public int PersonalBest() => Score.Max();

    public List<int> PersonalTopThree() => Score.OrderByDescending(x => x).Take(3).ToList();
}