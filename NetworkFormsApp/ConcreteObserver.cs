using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkFormsApp
{
    class ConcreteObserver: IObserver
    {
        ISubject subject;

        public ConcreteObserver(ISubject subject)
        {
            this.subject = subject;
            this.subject.Subscribe(this);
        }
        public void Update(string color)
        {
            Console.WriteLine(color);
        }
    }
}
