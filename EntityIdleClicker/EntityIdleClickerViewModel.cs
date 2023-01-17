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
            Clicker.FirstEntity.PropertyChanged += FirstEntity_PropertyChanged;
        }

        private void FirstEntity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FirstEntityCount = Clicker.FirstEntity.Count;
            FirstEntityGeneration = Clicker.FirstEntity.Generates;
        }

        public BigInteger FirstEntityCount { get; set; }

        public BigInteger FirstEntityGeneration { get; set; }

        public BigInteger RoundResources { get; set; }

        private EntityIdleClicker _clicker;
        public EntityIdleClicker Clicker { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

