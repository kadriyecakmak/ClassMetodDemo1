using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class BestMyList<K>

    {
        K[] items;

        public BestMyList()
        {
            items = new K[0];
        }
        public void Add(K item)
        {
            K[] tempArray = items;
            items = new K[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
