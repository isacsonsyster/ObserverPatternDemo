using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    interface ISubscriber
    {
        void Subscribe(Viewer observer);
        void Unsubscribe(Viewer observer);
        void Notify();
    }
}
