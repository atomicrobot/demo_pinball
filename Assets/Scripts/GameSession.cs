using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession {

    public int score
    {
        get;
        private set;
    }

    public static int PEG_SCORE_VALUE = 25;
    public static int PEG_FORCE = 11;
    public static int PADDLE_FORCE = 11;

    public GameSession()
    {
        score = 0;
    }

    public void raiseScore(int amount)
    {
        score = score + amount;
    }

}
