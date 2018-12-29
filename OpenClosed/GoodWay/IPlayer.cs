namespace OpenClosed.Goodway
{
    /// <summary>
    /// Additional player classes can be added by implementing this interface, therefore adhering to open/closed principle as this interface
    /// would not be modified but the behaviour can be extended in the derived class (Hunter/Mage/Warrior etc).
    /// </summary>
    public interface IPlayer
    {
        int Agility { get; }

        int Intelligence { get; }

        int Strength { get;}

        /// <summary>
        /// Attack with weapon and returns damage dealt.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        double Attack(Weapon weapon);
    }
}
