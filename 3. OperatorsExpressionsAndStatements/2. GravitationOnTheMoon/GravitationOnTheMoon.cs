/* The gravitational field of the Moon is approximately 17% 
 * of that on the Earth. Write a program that calculates 
 * the weight of a man on the moon by a given weight on the Earth. */

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Weight: ");
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = (17 * weightEarth) / 100;
        Console.WriteLine("The weight on the Moon is: {0}", weightMoon);
    }
}