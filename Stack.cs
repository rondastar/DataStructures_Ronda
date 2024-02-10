using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Ronda
{
    // Ronda Rutherford
    // 2-10-24
    internal class Stack<T>
    {
        private StackNode<T> top;   // top element in the stack
        private int count;          // tracks the number of elements in the stack

        internal Stack()
        {
            top = null;     
            count = 0;
        } // Stack constructor for empty stack

        internal class StackNode<T> // nested class for the nodes of the stack
        {
            internal T Value { get; set; }            // Data stored in the node
            internal StackNode<T> Next { get; set; }    // Reference to the next node

            internal StackNode(T value)   // creates a node with the given value
            {
                Value = value;
                Next = null;
            } // StackNode constructor

        } // StackNode nested class

        // Count provides access to the number of elements in the stack
        public int Count { get => count; set => count = value; }

        // Push adds an element to the top
        public void Push(T value)
        {
            // Create a new node with the input value
            StackNode<T> newNode = new StackNode<T>(value);

            if (newNode != null)
            {
                // Create a temporary node to keep track of the current top node
                StackNode<T> current = top;

                // Update the references of the new node so that the current top follows the new node
                newNode.Next = current;
            }

            // Assign the new node to be the top
            top = newNode;

            // increment count to reflect added element
            count++;

        } // Push

        // Pop removes and returns the element from the top
        public T Pop()
        {
            // If top is null, return default
            if (top == null)
            {
                return default(T);
            }

            // Assign value to be removed from top to a temporary variable
            T temp = top.Value;

            // If the next node is empty, reset top to null
            if (top.Next == null) top = null;

            // If the next node is not null, update reference so it is the new top
            else if (top.Next != null)
            {
                top = top.Next;
            }

            // decrement the count
            count--;

            // return the value that was removed
            return temp;
        } // Pop

        // Peek returns the value of the top without removing it
        public T Peek()
        {
            // If top is null, return default
            if (top == null)
            {
                return default(T);
            }

            // return the value of the top
            return top.Value;
        } // Peek

        public void Clear()
        {
            // runs until the stack is empty
            while (top != null)
            {
                // If the next node is empty, reset top to null
                if (top.Next == null) top = null;

                // If the next node is not null, update reference so it is the new top
                else if (top.Next != null)
                {
                    top = top.Next;
                }

                // decrement the count
                count--;
            }
        } // Clear

    } // Stack class
} // namespace
