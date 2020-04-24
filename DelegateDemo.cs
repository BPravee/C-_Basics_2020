using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public delegate void SortHandler();
    public class BinarySearch
    {
        public void Search(string item,SortHandler _handlerRef) {
            _handlerRef.Invoke();
            _handlerRef();//_handlerRef.Invoke();
        }
    }

    public class BubbleSort
    {

        public void Sort()
        {

        }
    }
    public class QuickSort
    {
        public void Quick() { }
    }
}
