// Silver
// Fire

using System;

public class Vampire : ICombustable, IWeapon
{
    private object attack;

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Vampire with Fire!");
        }
    }
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Vampire with Silver!");
        }
    }
}