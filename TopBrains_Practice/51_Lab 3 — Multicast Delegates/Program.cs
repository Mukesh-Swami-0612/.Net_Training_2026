using MulticastDelegateLab;

class Program
{
    static void Main()
    {
        // Create an object containing our handler methods.
        OrderHandlers handlers = new OrderHandlers();

        // Create an empty delegate variable.
        OrderEvent orderEvent = null!;


        // PART 1: ADD THREE HANDLERS

        Console.WriteLine("\n--- Part 1: Adding Three Handlers ---");

        orderEvent += handlers.LogToConsole;
        orderEvent += handlers.SendEmailSimulation;
        orderEvent += handlers.UpdateInventorySimulation;

        Console.WriteLine("Three handlers have been added.");


        // PART 2: INVOKE MULTICAST DELEGATE

        Console.WriteLine("\n--- Part 2: Invoking Multicast Delegate ---");

        Console.WriteLine("Calling orderEvent...\n");

        orderEvent("ORD-1001");

        Console.WriteLine("\nAll three handlers executed.");
        Console.WriteLine("They execute in the order in which they were added.");


        // PART 3: REMOVE ONE HANDLER

        Console.WriteLine("\n--- Part 3: Removing One Handler ---");

        orderEvent -= handlers.SendEmailSimulation;

        Console.WriteLine("SendEmailSimulation has been removed.");

        Console.WriteLine("\nCalling orderEvent again...\n");

        orderEvent("ORD-1002");

        Console.WriteLine("\nOnly the remaining two handlers executed.");


        // PART 4: LAMBDA REFERENCE-EQUALITY PITFALL

        Console.WriteLine("\n--- Part 4: Lambda Reference-Equality Pitfall ---");

        Console.WriteLine("\nAdding two identical-looking lambdas...");

        orderEvent += id =>
            Console.WriteLine($"[Lambda 1] Processing order: {id}");

        orderEvent += id =>
            Console.WriteLine($"[Lambda 1] Processing order: {id}");

        Console.WriteLine("\nCalling orderEvent...\n");

        orderEvent("ORD-1003");


        // TRY TO REMOVE A LAMBDA USING A NEW LAMBDA

        Console.WriteLine("\n--- Attempting Incorrect Lambda Removal ---");

        Console.WriteLine(
            "Trying to remove a lambda using a newly-created lambda..."
        );

        orderEvent -= id =>
            Console.WriteLine($"[Lambda 1] Processing order: {id}");

        Console.WriteLine("\nCalling orderEvent again...\n");

        orderEvent("ORD-1004");

        Console.WriteLine(
            "\nThe lambda was NOT removed because the lambda used "
            + "for -= was a different delegate instance."
        );


        // PART 5: CORRECT WAY - STORE THE LAMBDA

        Console.WriteLine("\n--- Correct Lambda Removal ---");

        // Store the lambda in a variable so we keep the
        // original delegate reference.
        OrderEvent storedLambda = id =>
            Console.WriteLine($"[Stored Lambda] Processing order: {id}");

        // Add the stored lambda.
        orderEvent += storedLambda;

        Console.WriteLine("\nCalling orderEvent after adding stored lambda...\n");

        orderEvent("ORD-1005");


        // Remove the exact same delegate reference.
        orderEvent -= storedLambda;

        Console.WriteLine("\nStored lambda has been removed.");

        Console.WriteLine("\nCalling orderEvent again...\n");

        orderEvent("ORD-1006");

        Console.WriteLine("\nStored lambda no longer executes.");

    }
}