namespace MulticastDelegateLab;

// Defines a delegate that accepts an order ID
// and does not return a value.
public delegate void OrderEvent(string orderId);