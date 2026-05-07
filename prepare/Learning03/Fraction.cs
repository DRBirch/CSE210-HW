using System;

public class Fraction
{
    private int _num;
    private int _den;

    public Fraction()
    {
        _num = 0;
        _den = 1;
    }

    public Fraction(int wholeNum)
    {
        _num = wholeNum;
        _den = 1;
    }

    public Fraction(int num, int den)
    {
        _num = num;
        if (den == 0)
        {
            _den = 1;
        }
        else
        {
            _den = den;
        }
    }

    public void SetNum(int num)
    {
        _num = num;
    }

    public void SetDen(int den)
    {
        if (den == 0)
        {
            _den = 1;
        }
        else
        {
            _den = den;
        }
    }

    public int GetNum()
    {
        return _num;
    }

    public int GetDen()
    {
        return _den;
    }

    public string Display()
    {
        return _num + "/" + _den;
    }

    public double ToDecimal()
    {
        return (double)_num / _den;
    }
}