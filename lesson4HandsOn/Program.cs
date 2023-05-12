// Part 1
int  DoubleMe(int num)
{
    return(num * 2);
}
Console.WriteLine("Doubled Number: " + DoubleMe(4));

// Part 2
int QuadrupleMe(int number)
{
    return(DoubleMe(DoubleMe(number)));
}
Console.WriteLine("Quadrupled Number: " + QuadrupleMe(5));

// Part 3
int DoubleNumberMultipleTimes(int numberToBeDoubled, int amountOfTimes)
{
    for (int i = 0; i < amountOfTimes; i++ )
    {
        numberToBeDoubled = DoubleMe(numberToBeDoubled);
    }
    return numberToBeDoubled;
}
Console.WriteLine("Number Doubled Many Times: " + DoubleNumberMultipleTimes(2, 3));