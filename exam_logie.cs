public class PointsCalculator
{
    public int CalculateMemberPoint(decimal receiptAmount)
    {
        int points = (int)(receiptAmount / 1000);

        decimal multiplier = GetBonusMultiplier(receiptAmount);

        points = (int)(points * multiplier);

        return points;
    }

    private decimal GetBonusMultiplier(decimal amount)
    {
        if  (amount >= 200000)
            return 11.0m;
        else if (amount >= 190000)
            return 10.5m;
        else if (amount >= 180000)
            return 10.0m;
        else if (amount >= 170000)
            return 9.5m;
        else if (amount >= 160000)
            return 9.0m;
        else if (amount >= 150000)
            return 8.5m;
        else if (amount >= 140000)
            return 8.0m;
        else if (amount >= 130000)
            return 7.5m;
        else if (amount >= 120000)
            return 7.0m;
        else if (amount >= 110000)
            return 6.5m;
        else if (amount >= 100000)
            return 6.0m;
        else if (amount >= 90000)
            return 5.5m;
        else if (amount >= 80000)
            return 5.0m;
        else if (amount >= 70000)
            return 4.5m;
        else if (amount >= 60000)
            return 4.0m;
        else if (amount >= 50000)
            return 3.5m;
        else if (amount >= 40000)
            return 3.0m;
        else if (amount >= 30000)
            return 2.5m;
        else if (amount >= 20000)
            return 2.0m;
        else if (amount >= 10000)
            return 1.5m;
        else
            return 1.0m;
    }
    
    public static void Main(string[] args)
    {
        PointsCalculator calculator = new PointsCalculator();
        Console.Write("Enter information amount : ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        int points = calculator.CalculateMemberPoint(amount);
        Console.WriteLine($"For spending {amount} baht, you receive {points} points.");
    }
}
