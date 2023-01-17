using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Threading;

namespace EntityIdleClicker
{
    class EntityIdleClicker : INotifyPropertyChanged
    {
        public EntityIdleClicker()
        {
            DispatcherTimerSetup();

            FirstEntity = new FirstEntity
            {
                State = true
            };
        }

        private FirstEntity _firstEntity;
        public FirstEntity FirstEntity
        { 
            get => _firstEntity;
            set
            {
                _firstEntity = value;
                NotifyPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DispatcherTimerSetup()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += new EventHandler(AccumulateResources);
            dispatcherTimer.Start();
        }

        private void AccumulateResources(object sender, EventArgs e)
        {
            
        }

        private IEntity AddCount(IEntity entity, BigInteger count)
        {
            
        }
    }
}
