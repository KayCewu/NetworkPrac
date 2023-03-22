using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkFormsApp
{
    //Concrete subject
    class NetworkProviders : ISubject
    {
        List<IObserver> Observers=new List<IObserver>();
        string color = "Red";
        public void Subscribe(IObserver Target)
        {
            Observers.Add(Target);
        }
        public void Notify(IObserver Target)
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(color);
            }
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        
        
    }
}
