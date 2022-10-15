// Created by: liya getachew 
// Created on: Oct 15 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int sideLengthOfSquare;

        Console.WriteLine("This program calculates the perimeter of a square in meters.");
        Console.WriteLine("");

        Console.Write("Enter side length of square (m): ");
        sideLengthOfSquare = Convert.ToInt32(Console.ReadLine());

        int perimeter = sideLengthOfSquare * 4;

        Console.WriteLine("");
        Console.WriteLine("Perimeter = " + perimeter + " m.");

        Console.WriteLine("\nDone");
    }
}