using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    private string title;
    private string author;
    private int year;
    private string genre;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }
    public virtual void Read()
    {
        Debug.Log("Reading a book...");
    }
}

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
