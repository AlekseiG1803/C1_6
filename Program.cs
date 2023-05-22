int number1 = new Random().Next(1, 10);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);
int number3 = new Random().Next(1, 10);
Console.WriteLine(number3);
int number4 = new Random().Next(1, 10);
Console.WriteLine(number4);
int number5 = new Random().Next(1, 10);
Console.WriteLine(number5);
int max = number1;
if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
if(max < number4)
{
    max = number4;
}
if(max < number5)
{
    max = number5;
}
Console.Write("Максимум равен: ");
Console.Write(max);

