using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintedBook : Book
{
    private int weight;

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private bool isDamaged;

    public bool IsDamaged
    {
        get { return isDamaged; }
        set { isDamaged = value; }
    }
    public override void Read()
    {
        Debug.Log("Flipping through the pages of a printed book...");
    }

}