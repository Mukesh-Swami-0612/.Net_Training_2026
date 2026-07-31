using System;

class HospitalQueue
{
    // Array used to store the names of waiting patients.
    string[] patient = new string[10];

    // Points to the first patient in the queue.
    int front = 0;

    // Points to the last patient in the queue.
    int rear = -1;

    /// <summary>
    /// Initializes the hospital queue by registering
    /// a few default patients.
    /// </summary>
    public HospitalQueue()
    {
        // Register the first patient.
        RegisterPatient("Rahul");

        // Register the second patient.
        RegisterPatient("Priya");

        // Register the third patient.
        RegisterPatient("Amit");
    }

    /// <summary>
    /// Registers a new patient by adding them
    /// to the end of the queue.
    /// </summary>
    public void RegisterPatient(string name)
    {
        // Check whether the queue is full.
        if (rear == patient.Length - 1)
        {
            Console.WriteLine("Queue Full");
            return;
        }

        // Add the patient to the queue.
        patient[++rear] = name;

        // Display a confirmation message.
        Console.WriteLine(name + " Registered");
    }

    /// <summary>
    /// Calls the next patient by removing
    /// them from the front of the queue.
    /// </summary>
    public void CallNextPatient()
    {
        // Check whether the queue is empty.
        if (front > rear)
        {
            Console.WriteLine("No Patients");
            return;
        }

        // Display the patient being called.
        Console.WriteLine("Calling: " + patient[front]);

        // Move the front pointer to the next patient.
        front++;
    }

    /// <summary>
    /// Displays the next patient waiting
    /// in the queue.
    /// </summary>
    public void ViewNextPatient()
    {
        // Check whether the queue is empty.
        if (front > rear)
            Console.WriteLine("No Patients");
        else
            // Display the next patient.
            Console.WriteLine("Next Patient: " + patient[front]);
    }

    /// <summary>
    /// Displays all patients currently
    /// waiting in the queue.
    /// </summary>
    public void DisplayPatients()
    {
        // Check whether there are any waiting patients.
        if (front > rear)
        {
            Console.WriteLine("No Waiting Patients");
            return;
        }

        // Display the heading.
        Console.WriteLine("Waiting Patients:");

        // Traverse and display all waiting patients.
        for (int i = front; i <= rear; i++)
        {
            Console.WriteLine(patient[i]);
        }
    }

    /// <summary>
    /// Searches for a patient in the queue
    /// by name.
    /// </summary>
    public void SearchPatient(string name)
    {
        // Variable to indicate whether the patient is found.
        bool found = false;

        // Search through the queue.
        for (int i = front; i <= rear; i++)
        {
            // Compare patient names ignoring letter case.
            if (patient[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        // Display the search result.
        if (found)
            Console.WriteLine("Patient Found");
        else
            Console.WriteLine("Patient Not Found");
    }

    /// <summary>
    /// Displays the total number of
    /// patients waiting in the queue.
    /// </summary>
    public void CountPatients()
    {
        // Check whether the queue is empty.
        if (front > rear)
            Console.WriteLine("Total Waiting Patients: 0");
        else
            // Display the total number of waiting patients.
            Console.WriteLine("Total Waiting Patients: " + (rear - front + 1));
    }
}