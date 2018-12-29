using System;

namespace OpenClosed.Goodway
{
    public class Hunter : IPlayer
    {
        public int Agility => 2;

        public int Intelligence => 2;

        public int Strength => 2;
        
        public double Attack(Weapon weapon)
        {
            switch (weapon)
            {
                case Weapon.Bow:
                    return this.Agility * 2;
                case Weapon.Staff:
                    return this.Intelligence * 1.5;
                case Weapon.Sword:
                    return this.Strength * 1.5;
                default:
                    throw new Exception($"Unknown weapon: {weapon}");
            }
        }
    }
}
