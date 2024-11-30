using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linkadas_Circulares
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator GetEnumerator() {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }

    
}