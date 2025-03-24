namespace hello_world.Utilities;

public class ECommerce
{
    private const double EARNINGS = 0.25;
    private const double TAX = 0.10;
    private const double COMMUNICATION_TAX = 0.05;

    public static void ConsumerPrice(string productName, double productPrice)
    {
        // productPrive = 40
        double productTaxes = productPrice * TAX;  // taxes = 4
        double productTotalCost = productTaxes + productPrice; // 44
        double earningPerProduct = productTotalCost * EARNINGS; //11
        double productPriceToSell = productTotalCost + earningPerProduct; // 55
        
        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Total cost: {productTotalCost}");
        Console.WriteLine($"The earnings are: {earningPerProduct}");
        Console.WriteLine($"The price to sell is: {productPriceToSell}");
    }
    
    public static void ComunicationPrice(double communicationPrice, double bytesPrice, double communicationTime, double bytesAmount)
    {
        double totalBytesPrice = bytesPrice * bytesAmount;
        double totalCommunicationPrice = communicationPrice * communicationTime;
        double totalCost = totalBytesPrice + totalCommunicationPrice; //dolares

        double extraCharge = Math.Ceiling(totalCost) * COMMUNICATION_TAX; 
        double finalCost = totalCost + extraCharge;
        
        Console.WriteLine($"Total cost: {totalCost}");
        Console.WriteLine($"Amount of change: {extraCharge}");
        Console.WriteLine($"Total cost for user: {finalCost}");
    }
    
}