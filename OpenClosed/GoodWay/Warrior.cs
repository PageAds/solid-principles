using System;

namespace OpenClosed.Goodway
{
    public class Warrior : IPlayer
    {
        public int Agility => 2;

        public int Intelligence => 2;

        public int Strength => 6;

        public double Attack(Weapon weapon)
        {
            switch (weapon)
            {
                case Weapon.Bow:
                    return this.Agility * 1.5;
                case Weapon.Staff:
                    return this.Intelligence * 1.5;
                case Weapon.Sword:
                    return this.Strength * 2;
                default:
                    throw new Exception($"Unknown weapon: {weapon}");
            }
        }
    }
}
