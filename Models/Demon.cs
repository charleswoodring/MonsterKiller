// Holy water
// Silver
// Fire

using System;

public class Demon : ICombustable, ILiquid, IWeapon
{
    private object attack;

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Demon with Fire!");
        }
    }
    public void Douse (string attack)
    {
        if (attack == "Splash") {
            Console.WriteLine("You just killed the Demon with Holy Water!");
        }
    }
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Demon with Silver!");
        }
    }
}