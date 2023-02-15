
bool Palindrome (int number)
{
    int numberToDivide = number;
    int reverseNumber = 0;
    bool result = true;
    while (numberToDivide > 0)
    {
        reverseNumber = reverseNumber * 10 + numberToDivide % 10;
        numberToDivide /= 10;
    }
    if (number != reverseNumber) result = false;
    return result;
}
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(number);
Console.WriteLine(result);