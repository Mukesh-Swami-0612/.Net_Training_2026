namespace Lab2Delegates;

public class DiscountService
{
    // Returns the original price without applying any discount.
    public double NoDiscount(double price)
    {
        return price;
    }

    // Applies a 10% discount to the given price.
    public double TenPercentOff(double price)
    {
        return price * 0.90;
    }

    // Applies a 50% discount to the given price.
    public double HalfOff(double price)
    {
        return price * 0.50;
    }

    // Invokes the discount delegate against the given price.
    public double ApplyDiscount(double price, Discount discount)
    {
        return discount(price);
    }
}