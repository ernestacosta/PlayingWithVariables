using System;

namespace PlayingWithVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dogName = "Ralph";
            int dogAge = 10;
            char firstInitial = 'R';
            bool lovesHiking = true;
            double tennisBalls = 32;
            decimal weight = 70.3m;

            Console.WriteLine($"My dog's name is {dogName}, He is " +
                $"{dogAge} years old and has {tennisBalls} tennis balls " +
                $"and it is {lovesHiking} that he loves to hike, which keeps " +
                $"him at a healthy weight of {weight} lbs"); 

        }
    }
}
