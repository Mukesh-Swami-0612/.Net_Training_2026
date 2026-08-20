using System;
using System.Collections.Generic;

/// <summary>
/// Tracks unique daily active users.
/// HashSet is used because duplicate user IDs should not be counted twice.
/// </summary>
public class DailyActiveUserTracker
{
    // HashSet stores unique user IDs.
    // One-line justification: HashSet<T> is best because it automatically prevents duplicates.
    private readonly HashSet<int> _userIds = new();

    /// <summary>
    /// Records a user's visit.
    /// </summary>
    public void RecordVisit(int userId)
    {
        // Add the user ID to the set.
        // If the user already exists, HashSet does not add a duplicate.
        _userIds.Add(userId);
    }

    /// <summary>
    /// Returns the number of unique visitors.
    /// </summary>
    public int UniqueVisitorCount()
    {
        // Return the number of unique user IDs.
        return _userIds.Count;
    }
}