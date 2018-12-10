using System.Collections;
using UnityEngine;
using System;

public class powerUps : IComparable<powerUps>

{
    public string name;
    public int power;

    public powerUps(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    public int CompareTo(powerUps other)
    {
        if(other == null)
        {
            return 1;
        }

        return power - other.power;
    }
}
