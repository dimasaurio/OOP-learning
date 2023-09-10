using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBook : Book
{
    // INHERITANCE
    private string fileFormat;

    // ENCAPSULATION
    public string FileFormat
    {
        get { return fileFormat; }
        set { fileFormat = value; }
    }

    private bool isFree;

    // ENCAPSULATION
    public bool IsFree
    {
        get { return isFree; }
        set { isFree = value; }
    }

    // POLYMORPHISM / ABSTRACTION
    public override void Read(PlayerController playerController)
    {
        playerController.DisplayMessage("Scrolling through the pages of an e-book...");
    }
}
