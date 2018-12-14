using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom
{
    class CustomList
    {
        private int[] _content;

        public int[] Content
        {
            get => _content;
            set => _content = value;
        }

        public CustomList()
        {
            _content = new int[0];
        }

        public void Add(int value)
        {
            int size = _content.Length;
            int[] tempArr = new int[size + 1];

            Array.Copy(_content, tempArr, size);
            tempArr[size] = value;
            _content = tempArr;
        }

        public void Remove(int value)
        {
            int index = Array.IndexOf(_content, value);

            int size = _content.Length;
            int[] tempArr = new int[size - 1];

            for (int i = index; i < _content.Length; i++)
            {
                if (i != _content.Length - 1)
                {
                    _content[i] = _content[i + 1];
                }
            }

            Array.Copy(_content, tempArr, size - 1);
            _content = tempArr;
        }

        public void Sort()
        {
            bool token = true;

            while (token) {
                int smallest = _content[0];
                int counter = 0;
                for (int i = 1; i < _content.Length; i++)
                {
                    int current = _content[i];

                    if (current < smallest)
                    {
                        int indexOfSmallest = Array.IndexOf(_content, smallest);
                        int indexOfCurrent = Array.IndexOf(_content, current);
                        _content[indexOfSmallest] = current;
                        _content[indexOfCurrent] = smallest;
                    }
                    else
                    {
                        ++counter;
                        if (counter == _content.Length - 1)
                        {
                            token = false;
                        }
                    }
                }
            }
        }

        public void Clear()
        {
            _content = new int[0];
        }
    }
}
