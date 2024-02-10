namespace DataStructures_Ronda
{
    // Ronda Rutherford
    // Midterm - Data Structures
    // 2-10-24
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueTest();
        } // Main

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
    }
}
