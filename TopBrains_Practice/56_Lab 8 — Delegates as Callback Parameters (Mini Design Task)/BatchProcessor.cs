using System;
using System.Collections.Generic;

namespace Lab8
{
    // This class contains the generic callback-based processing method.
    public class BatchProcessor
    {
        // Processes a list of items using a validator,
        // success callback, and failure callback.
        public void ProcessBatch<T>(
            List<T> items,
            Action<T> onSuccess,
            Action<T, string> onFailure,
            Func<T, bool> validator)
        {
            // Process every item in the list.
            foreach (T item in items)
            {
                // Check whether the current item is valid.
                if (validator(item))
                {
                    // If valid, call the success callback.
                    onSuccess(item);
                }
                else
                {
                    // If invalid, create a reason message.
                    string reason = "Item failed validation.";

                    // Call the failure callback with
                    // the item and failure reason.
                    onFailure(item, reason);
                }
            }
        }
    }
}