using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintedBook : Book
{
    // INHERITANCE
    private int weight;

    // ENCAPSULATION
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private bool isDamaged;

    // ENCAPSULATION
    public bool IsDamaged
    {
        get { return isDamaged; }
        set { isDamaged = value; }
    }

    // POLYMORPHISM / ABSTRACTION
    public override void Read(PlayerController playerController)
    {
        playerController.DisplayMessage("Flipping through the pages of a printed book...");
    }

}