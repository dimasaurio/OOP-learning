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
    public virtual void Read(PlayerController playerController)
    {
        playerController.DisplayMessage("Reading a book...");
    }
}
