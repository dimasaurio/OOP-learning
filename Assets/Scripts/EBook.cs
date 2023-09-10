using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBook : Book
{
    private string fileFormat;

    public string FileFormat
    {
        get { return fileFormat; }
        set { fileFormat = value; }
    }

    private bool isFree;

    public bool IsFree
    {
        get { return isFree; }
        set { isFree = value; }
    }
    public override void Read()
    {
        Debug.Log("Scrolling through the pages of an e-book...");
    }
}
