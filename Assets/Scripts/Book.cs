using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the IReadable interface
public interface IReadable
{
    void Read(PlayerController playerController);
}

public abstract class Book : MonoBehaviour, IReadable
{
    private string title;
    private string author;
    private int year;
    private string genre;

    // ENCAPSULATION
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

    // ABSTRACTION
    public abstract void Read(PlayerController playerController);
}