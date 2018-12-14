using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.StudentCodeReview.StackExample
{
    class Stack<T>
    {
        private List<T> _list = new List<T>();

        public void Push(T obj)
        {
            if (obj.Equals(null))
                throw new InvalidOperationException("You cannot add a null object to the stack.");

            _list.Add(obj);
        }

        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack.");

            var index = _list.Count - 1;

            var returnValue = _list[index];

            _list.RemoveAt(_list.Count - 1);

            return returnValue;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
