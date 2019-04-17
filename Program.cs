using System;
using System.Collections.Generic;


namespace MonsterKiller
{
    public class Hunter
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

    public Hunter (string first, string last) {
        FirstName = first;
        LastName = last;
    }
    public List<string> Monster { get; } = new List<string>() {
        "Demon", "Ghast", "Ghoul", "Mummy",
        "Vampire", "Wight", "Zombie"
    };

    public void SplashWater (ILiquid Monster) {
        Monster.Douse("Splash");  // Kills with holy water
    }

    public void Ignite (ICombustable Monster) {
        Monster.Burn("Fire");  // Kills with fire
    }

    public void WieldSilver (IWeapon Monster) {
        Monster.Stab("Silver");   // Stabs with silver knife
    }

    public override string ToString () {
        return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
    }
}
    class Program
    {
       public static void Main()
{
    Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

    Demon demon = new Demon(); // D is the type d is the object

    VonRimmersmark.Ignite(demon);
    VonRimmersmark.SplashWater(demon);
    VonRimmersmark.WieldSilver(demon);

}
}
}
