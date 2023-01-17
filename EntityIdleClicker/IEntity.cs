using System.Numerics;

namespace EntityIdleClicker
{
    internal interface IEntity
    {
        bool State { get; set; }

        BigInteger Count { get; set; }

        int GenerationBase { get; set; }

        int UpgradeCostBase { get; set; }
    }
}