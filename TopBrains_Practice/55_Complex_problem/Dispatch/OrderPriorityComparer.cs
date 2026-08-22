using QuickBite.Models;

namespace QuickBite.Dispatch;

// Summary: Defines custom priority ordering for Order objects.
public class OrderPriorityComparer : IComparer<Order>
{
    // Summary: Compares two orders using Express, VIP, time, and ID priority.
    public int Compare(Order? x, Order? y)
    {
        // Two references to the same object are equal.
        if (ReferenceEquals(x, y))
        {
            return 0;
        }

        // Null values are placed after valid orders.
        if (x is null)
        {
            return 1;
        }

        // Valid orders come before a null value.
        if (y is null)
        {
            return -1;
        }

        // Express orders must come before normal orders.
        int expressComparison =
            y.IsExpress.CompareTo(x.IsExpress);

        // Return immediately if Express priority differs.
        if (expressComparison != 0)
        {
            return expressComparison;
        }

        // VIP customers come before regular customers.
        int vipComparison =
            y.Customer.IsVip.CompareTo(x.Customer.IsVip);

        // Return immediately if VIP priority differs.
        if (vipComparison != 0)
        {
            return vipComparison;
        }

        // Earlier orders should be dispatched first.
        int timeComparison =
            x.PlacedAt.CompareTo(y.PlacedAt);

        // Return immediately if placement time differs.
        if (timeComparison != 0)
        {
            return timeComparison;
        }

        // Use order ID as a final deterministic tie-breaker.
        return x.Id.CompareTo(y.Id);
    }
}