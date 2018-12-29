using System;

namespace OpenClosed.BadWay
{ 
    /// <summary>
    /// Whenever a new player class is added, the methods in this class will have to be modified.
    /// </summary>
    public class Player
    {
        public double Attack(Weapon weapon, PlayerClass playerClass)
        {
            switch (weapon)
            {
                case Weapon.Bow:
                    return this.CalculateBowDamage(playerClass);
                case Weapon.Staff:
                    return this.CalculateStaffDamage(playerClass);
                case Weapon.Sword:
                    return this.CalculateSwordDamage(playerClass);
            }

            throw new Exception($"Unknown weapon: {weapon}");
        }

        private double CalculateBowDamage(PlayerClass playerClass)
        {
            int hunterAgility = 6;
            int mageAgility = 2;
            int warriorAgility = 2;

            if (playerClass == PlayerClass.Hunter)
            {
                return hunterAgility * 2;
            }

            if (playerClass == PlayerClass.Mage)
            {
                return mageAgility * 1.5;
            }

            if (playerClass == PlayerClass.Warrior)
            {
                return warriorAgility * 1.5;
            }

            throw new Exception($"Unknown player class: {playerClass}");
        }

        private double CalculateStaffDamage(PlayerClass playerClass)
        {
            int hunterIntelligence = 2;
            int mageIntelligence = 6;
            int warriorIntelligence = 2;

            if (playerClass == PlayerClass.Hunter)
            {
                return hunterIntelligence * 1.5;
            }

            if (playerClass == PlayerClass.Mage)
            {
                return mageIntelligence * 2;
            }

            if (playerClass == PlayerClass.Warrior)
            {
                return warriorIntelligence * 1.5;
            }

            throw new Exception($"Unknown player class: {playerClass}");
        }

        private double CalculateSwordDamage(PlayerClass playerClass)
        {
            int hunterStrength = 2;
            int mageStrength = 2;
            int warriorStrength = 6;

            if (playerClass == PlayerClass.Hunter)
            {
                return hunterStrength * 1.5;
            }

            if (playerClass == PlayerClass.Mage)
            {
                return mageStrength * 1.5;
            }

            if (playerClass == PlayerClass.Warrior)
            {
                return warriorStrength * 2;
            }

            throw new Exception($"Unknown player class: {playerClass}");
        }
    }
}
