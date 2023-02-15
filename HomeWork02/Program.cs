double LineLength (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xProjectionLength = x2 - x1;
    double yProjectionLength = y2 - y1;
    double zProjectionLength = z2 - z1;
    double result = Math.Sqrt(Math.Pow(xProjectionLength, 2) + Math.Pow(yProjectionLength, 2) + Math.Pow(zProjectionLength, 2));
    return result;
}
Console.Write("Enter X coordinate of the 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of the 1st point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of the 1st point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X coordinate of the 2st point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of the 2st point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of the 2st point: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The length of the line is " + Math.Round(LineLength(x1, y1, z1, x2, y2, z2), 2));