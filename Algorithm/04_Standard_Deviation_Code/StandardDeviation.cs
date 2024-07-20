namespace Algorithm._02_Sigma_Notation_Standard_Deviation_Algorithm.Sigma_Notation;
public static class StandardDeviation
{
    public static double CalculateStandardDeviation()
    {
        double sd = 0, ave = 0, sum = 0;

        Console.WriteLine("Please Enter Size of Array You Want To Calculate Standard Deviation for it.");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        int i = 0;
        while (i < n)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            ave += numbers[i];
            i++;
        }

        i = 0;
        ave /= n;

        while (i < numbers.Length)
        {
            var num = numbers[i];
            sum += Math.Pow((numbers[i] - ave), 2);
            i++;
        }
        sum /= n;
        sd = Math.Sqrt(sum);
        return sd;
    }
}
