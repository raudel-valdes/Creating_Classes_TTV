using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_Classes_TTV
{
    class MediaLibrary
    {
        private MediaTypeBase[] _items;

        public MediaLibrary(MediaTypeBase[] items)
        {
            _items = items;
        }

        public MediaTypeBase GetItemAt(int index)
        {
            if(index <= _items.Length - 1 && index >= 0)
            {
                return _items[index];
            }

            Console.WriteLine("An element at index " + index + " doesn't exist in the MediaLibrary.");

            return null;
        }
    }
}
