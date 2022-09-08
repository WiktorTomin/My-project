//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int mean1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int mean2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int mean3 = int.Parse(Console.ReadLine());

    if (mean1 > mean2 && mean1 > mean3)
    {
        Console.WriteLine($"Максимальное число {mean1}");
    }
    
    else if (mean2 > mean1 && mean2 > mean3)
    {
      Console.WriteLine($"Максимальное число {mean2}");   
    }

     else if (mean3 >mean1 && mean3 > mean2)
     {
        Console.WriteLine($"Максимальное число {mean3}");
     }
    //Задача №4 решена.