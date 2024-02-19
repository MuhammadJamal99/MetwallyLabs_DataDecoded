namespace Algorithm.Trapezoid;
public static class Trapezoid
{
    public static double CalculateTrapezoidArea(double firstBaselen, double secoundBaselen, double hight)
    {
        double area = (0.5 * (firstBaselen + secoundBaselen)) * hight;
        return area;
    }
}
