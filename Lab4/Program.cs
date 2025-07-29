﻿using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Prblem 1: Method with no parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Method with parameters
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove {miles} miles.");
    }

    // Problem 3: Method with return value
    public string GetDescription()
    {
        return "{year} {color} {model}";
    }

    // problem 4: Method that updates a field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine("The car has been repainted to {newColor}.");
    }
}
class program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method 

        // Problem 1: Call Start()
        myCar.Start();

        // Problem 2: Call Drive(50)
        myCar.Drive(50);

        // Problem 3: Call GerDescription() and print result
        string description = myCar.GetDescription();

        Console.WriteLine(description);

        // Problem 4: Call Repaint("red") and confirm color change
        myCar.Repaint("red");
        Console.WriteLine("Confirm new color: {myCar.color}");
    }
}
