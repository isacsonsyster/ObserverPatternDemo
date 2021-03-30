using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Viewer : IViewer
    {
        public string ViewerName { get; private set; }

        public Viewer(string name)
        {
            ViewerName = name;
        }

        public void Update()
        {
            Console.WriteLine(ViewerName + ": A new product has arrived at the store");
        }
    }
}
