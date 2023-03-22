using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkFormsApp
{
    interface ISubject
    {
        void Subscribe(IObserver Target);
        void Notify(IObserver Target);
    }
}
