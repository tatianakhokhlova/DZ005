// Функцию, которая вычисляет число a в степени n
    int StepNum(int num, int n)
    {
    int num_n = 1;
    for(int i=0; i<n; i++) 
        num_n*=num;
    Console.WriteLine($"{num} ^ {n} = {num_n}"); 
    return 0;
    }

// Функцию, которая вычисляет факториал числа n
    int FactorialNum(int number)
    {
        if(number==1) return 1;
        else return number * FactorialNum(number-1);
    }

 // Функцию, которая вычисляет сумму цифр произвольного целого числа n
        int SummaN(int Number)
    {
        int Sum = 0;
        for (int n = Number; n > 0; Sum += n % 10, n /= 10) ;
        return Sum;
    }

//  Функцию, складывающую два целых числа
    int SummaNumber(int a, int b)
    {
    int summa = a + b;
    return summa;
    }

// Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
    bool TrueEven(int c)
    {
        if(c%2==0)
        return true;
        else
        return false;
    }

// Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
bool IsPrime(int d)
{
    if(d>1)
    {
        for(int i = 2; i<d; i++)
            if(d%i==0)
               return false;
        return true;
    }
    else
        return false;
}

// Функцию, которая проверяет является ли заданное число n полиндромом
bool PalindromeNum(int numb)
{
   int num5 = numb % 10;
   int num4 = numb / 10 % 10;
   int num3 = numb / 1000 % 10;
   int num1 = numb / 10000;

    if(num5==num1 && num4==num3)
       return true;
    else
       return false;
       
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(StepNum(num, n));

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа: {FactorialNum(number)}");

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел: {SummaNumber(a,b)}");

Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Проверка числа на четность: {TrueEven(c)}");

Console.WriteLine("Введите число: ");
int d = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число простое: {IsPrime(d)}");

Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число является палиндромом: {PalindromeNum(numb)}");

 Console.WriteLine("Введите число");
int Number = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр в числе: {SummaN(Number)}");



