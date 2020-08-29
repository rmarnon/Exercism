using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> Score { get; set; } = new List<int>();

    public HighScores(List<int> list)
    {
        Score = list;
    }

    public List<int> Scores() => Score;

    public int Latest() => Score.Last();

    public int PersonalBest() => Score.Max();

    public List<int> PersonalTopThree()
    {
        Score.Sort();
        List<int> _3Max = new List<int>(); 

        if (Score.Count < 4)
        {
            for (int i = 1; i <= Score.Count; i++)
            {
                _3Max.Add(Score[Score.Count - i]);
            }
        }
        else
        {
            for (int i = 1; i < 4; i++)
            {
                _3Max.Add(Score[Score.Count - i]);
            }
        }
        return _3Max;
    }
}