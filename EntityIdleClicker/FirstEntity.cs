using System.Numerics;

namespace EntityIdleClicker
{
    internal class FirstEntity : IEntity
    {
        public bool State { get; set; }
        public BigInteger Count { get ; set ; }
        public int GenerationBase { get ; set ; }
        public int UpgradeCostBase { get ; set ; }

        public FirstEntity()
        {
            State = false;
            Count = 1;
            GenerationBase = 1;
            UpgradeCostBase = 1;
        }
    }
}