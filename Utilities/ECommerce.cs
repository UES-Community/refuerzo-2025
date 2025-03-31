namespace hello_world.Utilities;

public class ECommerce
{
    private const double EARNINGS = 0.25;
    private const double TAX = 0.10;
    private const double COMMUNICATION_TAX = 0.05;

    public static void ConsumerPrice(string productName, double productPrice)
    {
        // productPrive = 40
        double productTaxes = productPrice * TAX; // taxes = 4
        double productTotalCost = productTaxes + productPrice; // 44
        double earningPerProduct = productTotalCost * EARNINGS; //11
        double productPriceToSell = productTotalCost + earningPerProduct; // 55

        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Total cost: {productTotalCost}");
        Console.WriteLine($"The earnings are: {earningPerProduct}");
        Console.WriteLine($"The price to sell is: {productPriceToSell}");
    }

    public static void ComunicationPrice(double communicationPrice, double bytesPrice, double communicationTime,
        double bytesAmount)
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

    public static void PriceToPay(int appointmentsCount)
    {
        double priceToPay = 0.0;
        double totalToPay = 0.0;

        // 3 -- 5
        // 5 -- 4
        // 8 -- 3
        // 9 -- 2.5

        switch (appointmentsCount)
        {
            case <= 3:
                priceToPay = 5.00;
                totalToPay = appointmentsCount * priceToPay;
                break;
            case <= 5:
                priceToPay = 4.00;
                totalToPay = 3 * 5.00 + (appointmentsCount - 3) * priceToPay;
                break;
            case <= 8:
                priceToPay = 3.00;
                totalToPay = (3 * 5.00) + (2 * 4.00) + ((appointmentsCount - 5) * priceToPay);
                break;
            default:
                priceToPay = 2.50;
                totalToPay = (3 * 5.00) + (2 * 4.00) + (3 * 3.00) + ((appointmentsCount - 8) * priceToPay);
                break;
        }

        // if (appointmentsCount <= 3)
        // {
        //     priceToPay = 5.00;
        //     totalToPay = appointmentsCount * priceToPay;
        // }
        //
        // else
        // {
        //     if (appointmentsCount <= 5)
        //     {
        //         priceToPay = 4.00;
        //         totalToPay = 3 * 5.00 + (appointmentsCount - 3) * priceToPay;
        //     }
        //     else
        //     {
        //         if (appointmentsCount <= 8)
        //         {
        //             priceToPay = 3.00;
        //             totalToPay = (3 * 5.00) + (2 * 4.00) + ((appointmentsCount - 5) * priceToPay);
        //         }
        //         else
        //         {
        //             priceToPay = 2.50;
        //             totalToPay = (3 * 5.00) + (2 * 4.00) + (3 * 3.00) + ((appointmentsCount - 8) * priceToPay);
        //         }
        //     }
        // }


        Console.WriteLine($"Total a pagar: ${totalToPay}");
        Console.WriteLine($"Actualmente su cuota de pago por cada cita es de: ${priceToPay}");
    }
}