// Creativity: I added a level system. The player gains one level for every 1000 points.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}