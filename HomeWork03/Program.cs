void Cubes(int number)
{
    for(int i = 1; i <= number; i++)
        Console.Write(Math.Pow(i, 3) + " ");
}

Console.Write("Enter N: ");
int number = Convert.ToInt32(Console.ReadLine());
Cubes(number);