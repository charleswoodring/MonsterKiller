// Fire

using System;

public class Zombie : ICombustable
{
    private object attack;

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Zombie with Fire!");
        }
    }
}