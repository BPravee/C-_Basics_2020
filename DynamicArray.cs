using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
   public class DynamicArray
    {
        //buffer
        int[] buffer = new int[10];

        //public void Set_Item(int index,int value)
        //{
        //    if(index >= this.buffer.Length)
        //    {
        //        //OverFlow
        //        //Create temp buffer
        //        int[] tempBuffer = new int[this.buffer.Length + index];
        //        //Copy Items from Old Buffer to New Buffer
        //        for(int i = 0; i < buffer.Length; i++)
        //        {
        //            tempBuffer[i] = buffer[i];
        //        }
        //        //Change Buffer Address
        //        this.buffer = tempBuffer;
        //    }
        //    this.buffer[index] = value;
        //}

        //public int Get_Item(int index)
        //{

        //    return this.buffer[index];

        //}

        #region Indexer - Allows indexing an object
        public int this[int index]
        {
            get { return this.buffer[index]; }
            set {
                if (index >= this.buffer.Length)
                {
                    //OverFlow
                    //Create temp buffer
                    int[] tempBuffer = new int[this.buffer.Length + index];
                    //Copy Items from Old Buffer to New Buffer
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        tempBuffer[i] = buffer[i];
                    }
                    //Change Buffer Address
                    this.buffer = tempBuffer;
                }
                this.buffer[index] = value;
            }
        }
        #endregion
    }
}
