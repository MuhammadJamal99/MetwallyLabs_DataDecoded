namespace Algorithm.Circle;
public static class Circle
{
    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}
