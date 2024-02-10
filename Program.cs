namespace DataStructures_Ronda
{
    // Ronda Rutherford
    // Midterm - Data Structures
    // 2-10-24
    internal class Program
    {
        static void Main(string[] args)
        {
            StackTest();
            //QueueTest(); 
        } // Main

        static void StackTest()
        {
            // ====== Test stack with string ===========================
            Console.WriteLine("Test stack with string:");
            // create a new stack
            Stack<string> stack = new Stack<string>();

            // test push
            stack.Push("apricot");
            stack.Push("banana");
            stack.Push("coconut");
            stack.Push("durian");
            stack.Push("eggplant");

            // test count
            Console.WriteLine(stack.Count); // 5

            // test pop
            stack.Pop();

            // test peek
            Console.WriteLine(stack.Peek()); // durian

            // test clear
            stack.Clear();

            // test count
            Console.WriteLine(stack.Count); // 0

            // test peek
            Console.WriteLine(stack.Peek()); // blank

            // test pop
            Console.WriteLine(stack.Pop()); // blank

            // test push
            stack.Push("apple");

            // test pop
            Console.WriteLine(stack.Pop()); // apple

            // test peek
            Console.WriteLine(stack.Peek()); // blank

            // ====== Test stack with float ===========================
            Console.WriteLine("Test stack with float:");
            // create a new stack
            Stack<float> stackFloat = new Stack<float>();

            // test push
            stackFloat.Push(1.2F);
            stackFloat.Push(2.3F);
            stackFloat.Push(3.4F);
            stackFloat.Push(4.4F);
            stackFloat.Push(5.6F);

            // test count
            Console.WriteLine(stackFloat.Count); // 5

            // test pop
            stackFloat.Pop();

            // test peek
            Console.WriteLine(stackFloat.Peek()); // 4.4

            // test clear
            stackFloat.Clear();

            // test count
            Console.WriteLine(stackFloat.Count); // 0

            // test peek
            Console.WriteLine(stackFloat.Peek()); // 0

            // test pop
            Console.WriteLine(stackFloat.Pop()); // 0

            // test push
            stackFloat.Push(7.5F);

            // test pop
            Console.WriteLine(stackFloat.Pop()); // 7.5

            // test peek
            Console.WriteLine(stackFloat.Peek()); // 0

        } // StackTest

        static void QueueTest()
        {
            // ===== test queue with string ===========================
            Console.WriteLine("Queue Test - string");
            Queue<string> stringQueue = new Queue<string>();

            // test enqueue
            stringQueue.Enqueue("Apple");
            stringQueue.Enqueue("Banana");
            stringQueue.Enqueue("Cherry");
            stringQueue.Enqueue("Dragonfruit");

            // test count
            Console.WriteLine(stringQueue.Count); // 4

            // test dequeue
            Console.WriteLine(stringQueue.Dequeue()); // Apple

            // test peek
            Console.WriteLine(stringQueue.Peek()); // Banana

            // test clear
            stringQueue.Clear();

            // test dequeue when empty
            Console.WriteLine(stringQueue.Dequeue()); // empty

            // test peek when empty
            Console.WriteLine(stringQueue.Peek()); // empty

            // test count
            Console.WriteLine(stringQueue.Count); // 0


            // ===== test queue with int ===========================
            Console.WriteLine("Queue Test - int");
            Queue<int> intQueue = new Queue<int>();

            // test enqueue
            intQueue.Enqueue(10);
            intQueue.Enqueue(20);
            intQueue.Enqueue(30);
            intQueue.Enqueue(40);

            // test count
            Console.WriteLine(intQueue.Count); // 4

            // test dequeue
            Console.WriteLine(intQueue.Dequeue()); // 10

            // test peek
            Console.WriteLine(intQueue.Peek()); // 20

            // confirm count
            Console.WriteLine(intQueue.Count); // 3

            // test clear
            intQueue.Clear();

            // test dequeue
            Console.WriteLine(intQueue.Dequeue()); // 0

            // test peek
            Console.WriteLine(intQueue.Peek()); // 0

            // test count
            Console.WriteLine(intQueue.Count); // 0
        } // QueueTest
    } // class
} // namespace
