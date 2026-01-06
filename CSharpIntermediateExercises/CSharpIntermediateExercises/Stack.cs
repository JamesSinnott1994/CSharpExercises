using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class Stack
    {
        ArrayList _stack;

        public Stack() {
            _stack = new ArrayList();
        }

        public void Push(object obj) {
            // Throw InvalidOperationException
            if (obj == null)
                throw new InvalidOperationException("You cannot add a null object to the stack.");

            _stack.Add(obj);
        }

        public object Pop() {

            if (_stack.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack yet.");
            object removed = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return removed;
        }

        public void Clear() {
            _stack.Clear();
        }
    }
}
