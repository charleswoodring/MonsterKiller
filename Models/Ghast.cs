// Holy water
// Fire

using System;

public class Ghast : ICombustable, ILiquid
{
    private object attack;

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Ghast with Fire!");
        }
    }
    public void Douse (string attack)
    {
        if (attack == "Splash") {
            Console.WriteLine("You just killed the Ghast with Holy Water!");
        }
    }
}