using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace EntityIdleClicker
{
    internal class FirstEntity : IEntity, INotifyPropertyChanged
    {
        private BigInteger _count;
        private bool _state;
        private int generationBase;
        private int upgradeCostBase;
        private BigInteger _generates;

        public bool State
        { 
            get => _state;
            set
            {
                _state = value;
                NotifyPropertyChanged();
            }
        }

        public BigInteger Count
        {
            get => _count;
            set
            {
                _count = value;
                NotifyPropertyChanged();
            } 
        }

        public BigInteger Generates
        {
            get => generationBase * Count;
            set
            {
                _generates = value;
                NotifyPropertyChanged();
            }
        }

        public FirstEntity()
        {
            State = false;
            Count = 1;
            generationBase = 1;
            upgradeCostBase = 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}