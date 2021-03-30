using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subscribers();

            Viewer observer1 = new Viewer("Observer 1");
            subject.Subscribe(observer1);

            Viewer observer2 = new Viewer("Observer 2");
            subject.Subscribe(observer2);

            subject.Inventory++;

            Viewer observer3 = new Viewer("Observer 3");
            subject.Subscribe(observer3);

            subject.Inventory++;

            Console.ReadLine();
        }
    }
}
