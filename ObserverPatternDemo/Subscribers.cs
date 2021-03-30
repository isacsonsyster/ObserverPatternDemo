using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subscribers : ISubscriber
    {
        private List<Viewer> observers = new List<Viewer>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Viewer observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Viewer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
