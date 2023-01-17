using System.Numerics;

namespace EntityIdleClicker
{
    internal interface IEntity
    {
        bool State { get; set; }

        BigInteger Count { get; set; }

        BigInteger Generates { get; set; }
    }
}