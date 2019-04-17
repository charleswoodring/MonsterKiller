// Fire

using System;

public class Mummy : ICombustable
{
    private object attack;

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Mummy with Fire!");
        }
    }
}