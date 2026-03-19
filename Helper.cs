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
    
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
    
        int max = values[0];
        foreach (int val in values) 
        {
            if (val > max) max = val;
        }
        return max;
    }
    
    public static int CalculateMin(int[] values)
    {
        // Tu bedzie logika
        return 0;
    }
}