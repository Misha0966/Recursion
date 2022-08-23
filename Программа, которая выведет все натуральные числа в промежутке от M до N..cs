//M = 5; N = 1. -> "5, 4, 3, 2, 1"
//M = 8; N = 4. -> "8, 7,6, 5, 4"


//  ввод входных параметров задачи
Console.WriteLine("Поиск натуральных чисел в промежутке от M до N: ");
Console.Write("Введите значение M: ");
int numberOne=Convert.ToInt32(Console.ReadLine()); // создание первой переменной
Console.Write("Введите значение N: ");
int numberTwo=Convert.ToInt32(Console.ReadLine()); // создание второй переменной
string result = NumbersInRange(numberOne, numberTwo); //создание результата для строки
Console.WriteLine($"M = {numberOne}; N = {numberTwo}. - > {result}");

string NumbersInRange(int numberOne, int numberTwo) // создание номерного диапазона для строки
{
    if (numberOne > numberTwo) // пока первая переменная больше второй переменной, то
    {
        return NumbersInRange(numberOne, numberTwo+1) + ", " + numberTwo; // возвращай номерной диапазон
    }
    else // иначе
    
    if(numberOne < numberTwo) // пока первая переменная меньше второй переменной, то
    {
        return NumbersInRange(numberOne+1, numberTwo) + ", " + numberOne; // возвращай номерной диапазон
    }
    {
        return Convert.ToString(numberTwo); // возвращай метод,который принимает два целых числа и переводит вторую переменную в эквивалентное ему строковое представление 
    }
}