using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // ============================================================
        // 1. INFINITE FIBONACCI ITERATOR
        // ============================================================

        Console.WriteLine("===== 1. Fibonacci Iterator =====");

        // Fibonacci() is infinite, so Take(10) limits consumption to 10 values.
        foreach (int number in FibonacciIterator.Fibonacci().Take(10))
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // ============================================================
        // 2. TAKE WHILE POSITIVE
        // ============================================================

        Console.WriteLine("===== 2. TakeWhilePositive =====");

        int[] numbers =
        {
            10, 20, 30, 40, 0, 50, 60
        };

        // The iterator stops when it reaches 0.
        foreach (int number in PositiveIterator.TakeWhilePositive(numbers))
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // ============================================================
        // 3. LAZY EVALUATION
        // ============================================================

        Console.WriteLine("===== 3. Lazy Evaluation =====");

        Console.WriteLine("Before calling iterator:");

        // Calling the iterator does NOT execute its body yet.
        var lazyResult = LazyDemo.GenerateNumbers();

        Console.WriteLine("After calling iterator:");

        Console.WriteLine("Starting foreach:");

        // The iterator body starts executing here.
        foreach (int number in lazyResult)
        {
            Console.WriteLine($"Received: {number}");
        }

        Console.WriteLine("Finished foreach.");
        Console.WriteLine();


        // ============================================================
        // 4. TREE DEPTH-FIRST TRAVERSAL
        // ============================================================

        Console.WriteLine("===== 4. Tree DFS Iterator =====");

        // Create the root node.
        TreeNode<string> root = new TreeNode<string>("A");

        // Create first-level children.
        TreeNode<string> b = new TreeNode<string>("B");
        TreeNode<string> c = new TreeNode<string>("C");

        // Create second-level children.
        TreeNode<string> d = new TreeNode<string>("D");
        TreeNode<string> e = new TreeNode<string>("E");
        TreeNode<string> f = new TreeNode<string>("F");

        // Build the tree.
        root.AddChild(b);
        root.AddChild(c);

        b.AddChild(d);
        b.AddChild(e);

        c.AddChild(f);

        // Traverse the tree using foreach.
        foreach (string value in root)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // ============================================================
        // 5. MyList<T>.InReverse()
        // ============================================================

        Console.WriteLine("===== 5. MyList InReverse Iterator =====");

        MyList<int> list = new MyList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        Console.WriteLine("Original list:");

        foreach (int number in list)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Reverse traversal:");

        // InReverse() produces elements from the last index to the first.
        // It does not create a second array.
        foreach (int number in list.InReverse())
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}