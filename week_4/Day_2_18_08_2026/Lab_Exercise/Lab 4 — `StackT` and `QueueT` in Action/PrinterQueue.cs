using System;
using System.Collections.Generic;

public class PrinterQueue
{
    // Store normal print jobs.
    private Queue<PrintJob> normalQueue;

    // Store high-priority print jobs.
    private Queue<PrintJob> priorityQueue;


    // Summary: Creates the normal and priority queues.
    public PrinterQueue()
    {
        // Create the normal print-job queue.
        normalQueue = new Queue<PrintJob>();

        // Create the priority print-job queue.
        priorityQueue = new Queue<PrintJob>();
    }


    // Summary: Adds a normal print job to the normal queue.
    public void AddJob(PrintJob job)
    {
        // Add the job to the end of the normal queue.
        normalQueue.Enqueue(job);
    }


    // Summary: Adds a high-priority print job to the priority queue.
    public void AddPriorityJob(PrintJob job)
    {
        // Add the priority job to the end of the priority queue.
        priorityQueue.Enqueue(job);
    }


    // Summary: Processes priority jobs first and then normal jobs.
    public void ProcessJobs()
    {
        // Queue<T> follows FIFO, so it cannot directly insert
        // a new job at the front of an existing queue.
        //
        // Two queues are used:
        // priorityQueue for high-priority jobs
        // normalQueue for regular jobs
        //
        // The priority queue is always checked first.

        // Continue until both queues are empty.
        while (priorityQueue.Count > 0 ||
               normalQueue.Count > 0)
        {
            // Store the queue that should be processed next.
            Queue<PrintJob> currentQueue;

            // Process priority jobs before normal jobs.
            if (priorityQueue.Count > 0)
            {
                // Select the priority queue.
                currentQueue = priorityQueue;
            }
            else
            {
                // Select the normal queue when no priority jobs exist.
                currentQueue = normalQueue;
            }

            // Peek at the next job without removing it.
            PrintJob nextJob = currentQueue.Peek();

            // Display the next job before processing it.
            Console.WriteLine(
                $"Now printing next: {nextJob.DocumentName} ({nextJob.Pages} pages)"
            );

            // Remove the next job from the queue.
            PrintJob job = currentQueue.Dequeue();

            // Display the job being printed.
            Console.WriteLine(
                $"Printing {job.DocumentName} ({job.Pages} pages)..."
            );
        }
    }
}