public class PrintJob
{
    // Document name of the print job.
    public string DocumentName { get; set; }

    // Number of pages in the print job.
    public int Pages { get; set; }


    // Summary: Creates a print job with a document name and page count.
    public PrintJob(string documentName, int pages)
    {
        // Store the document name.
        DocumentName = documentName;

        // Store the number of pages.
        Pages = pages;
    }
}