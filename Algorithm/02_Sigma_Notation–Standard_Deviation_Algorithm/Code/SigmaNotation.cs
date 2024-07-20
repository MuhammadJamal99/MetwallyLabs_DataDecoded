namespace Algorithm._02_Sigma_Notation_Standard_Deviation_Algorithm.Code;
internal class SigmaNotation
{
    public static double CalculateSigmaNotation(int numberOfIteration)
    {
        double sum = 0;
        for (int i = 1; i <= numberOfIteration; i++)
        {
            sum += (2 * i - 1);
        }
        return sum;
    }
}
