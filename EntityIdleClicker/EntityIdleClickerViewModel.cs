using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace EntityIdleClicker
{
    class EntityIdleClickerViewModel : INotifyPropertyChanged
    {
        public EntityIdleClickerViewModel()
        {
            _clicker = new EntityIdleClicker();
        }

        public BigInteger FirstEntityCount { get; set; }

        public BigInteger FirstEntityGeneration { get; set; }

        public BigInteger RoundResources { get; set; }

        private EntityIdleClicker _clicker;
        public EntityIdleClicker Clicker
        {
            get
            {
                return _clicker;
            }
            set
            {
                _clicker = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

