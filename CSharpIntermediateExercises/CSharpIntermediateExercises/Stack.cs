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
        ArrayList stack;

        public Stack() {
            stack = new ArrayList();
        }

        public void Push(object obj) {
            // Throw InvalidOperationException
            if (obj != null)
                stack.Add(obj);
        }

        public object Pop() {
            // Throw InvalidOperationException
            if (stack.Count > 0) {
                object removed = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return removed;
            }
            return "Nothing to pop";
        }

        public void Clear() {
            stack.Clear();
        }
    }
}
