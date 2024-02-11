namespace DataStructures_Ronda
{
    // Ronda Rutherford
    // Midterm - Data Structures
    // 2-10-24
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyTest();
            //StackTest();
            //QueueTest();
        } // Main

        static void DoublyTest()
        {
            // ======= Test doubly linked list with string =================
            Console.WriteLine("Test doubly linked list with string:");

            // create new doubly linked list
            LinkedListDoubly<string> doublyString = new LinkedListDoubly<string>();

            // test remove methods when null
            Console.WriteLine(doublyString.RemoveAtFront()); // blank
            //Console.WriteLine(doublyString.RemoveAtIndex(2)); // throw exception
            Console.WriteLine(doublyString.RemoveAtEnd()); // blank

            // test add and insert methods
            doublyString.Add("Apple");
            doublyString.InsertAtFront("Banana");
            doublyString.InsertAtIndex(1, "Cantaloupe");
            doublyString.InsertAtEnd("Dragonfruit");
            doublyString.Add("Eggplant");

            // test count and display
            Console.WriteLine(doublyString.Count); // 5
            doublyString.DisplayForward(); // Banana Cantaloupe Apple Dragonfruit Eggplant

            // test remove methods 
            Console.WriteLine(doublyString.Remove("Cantaloupe")); // true
            Console.WriteLine(doublyString.RemoveAtFront()); // Banana

            doublyString.DisplayBackward(); // Eggplant Dragonfruit Apple
            Console.WriteLine(doublyString.RemoveAtIndex(1)); // Dragonfruit
            Console.WriteLine(doublyString.RemoveAtEnd()); // Eggplant

            // test count and display
            Console.WriteLine(doublyString.Count); // 1
            doublyString.DisplayForward(); // Apple

            // ======= Test doubly linked list with double =================
            Console.WriteLine("Test doubly linked list with double:");
            LinkedListDoubly<double> doublyDouble = new LinkedListDoubly<double>();

            // test add and insert methods
            doublyDouble.Add(1.1);
            doublyDouble.InsertAtFront(0.5);
            doublyDouble.InsertAtIndex(1, 0.75);
            doublyDouble.InsertAtEnd(2.2);
            doublyDouble.Add(3.3);

            // test count and display
            Console.WriteLine(doublyDouble.Count); // 5
            doublyDouble.DisplayBackward(); // 3.3, 2.2, 1.1, 0.75, 0.5

            // test remove
            doublyDouble.Remove(1.1);
            Console.WriteLine(doublyDouble.RemoveAtIndex(0)); // 0.5

            doublyDouble.DisplayForward(); // 0.75. 2.2, 3.3
            Console.WriteLine(doublyDouble[2]); // 3.3
            Console.WriteLine(doublyDouble.Count); // 3

        }
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
