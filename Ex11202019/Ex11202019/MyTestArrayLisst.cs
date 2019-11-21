using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11202019
{
    class MyTestArrayLisst : ICollection
    {
        object[] listOject;
        int count;
        private int capacity;

        public int Count
        {
            get { return count; }

            private set
            {
                count = value;

                if (count > Capacity)
                {
                    Capacity = (Capacity == 0 ? 4 : Capacity * 2);
                    object[] lstNewObj = new object[Capacity];

                    this.CopyTo(lstNewObj, 0);
                    this.listOject = lstNewObj;
                }
            }
        }
        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public void CopyTo(Array array, int index)
        {
            listOject.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
