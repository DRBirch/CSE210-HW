using System;

public class Player
{
    private int _score;
    private int _level;

    public Player()
    {
        _score = 0;
        _level = 0;
    }

    public void AddScore(int points)
    {
        _score += points;
        CalculateLevel();
    }

    public void CalculateLevel()
    {
        _level = _score / 100;
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetLevel()
    {
        return _level;
    }
}