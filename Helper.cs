namespace DefaultNamespace;

public class Helper
{
    public static void WypiszLiczby(string input)
    {
        Console.WriteLine("Wprowadzone przez Ciebie dane to: " + input);
    }
    
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
    
        double sum = 0;
        foreach (int val in values) 
        {
            sum += val;
        }
        return sum / values.Length;
    }
}