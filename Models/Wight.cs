// Silver

using System;

public class Wight : IWeapon
{
    private object attack;
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Wight with Silver!");
        }
    }
}