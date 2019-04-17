// Holy water
// Silver

using System;

public class Ghoul : ILiquid, IWeapon
{
    private object attack;

    public void Douse (string attack)
    {
        if (attack == "Splash") {
            Console.WriteLine("You just killed the Ghoul with Holy Water!");
        }
    }
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Ghoul with Silver!");
        }
    }
}