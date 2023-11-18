// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// void Counter(int size)
// {
//     Console.WriteLine("Введите числа:");
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (Convert.ToInt32(Console.ReadLine()) > 0){
//             count++;
//         }
//     }
//     Console.WriteLine($"Введено чисел больше 0 -> {count}");
// }


// Console.Write("Введите кол-во чисел -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Counter(n);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Cord()
{
    double b1 = Convert.ToInt32(Console.ReadLine());
    double k1 = Convert.ToInt32(Console.ReadLine());
    double b2 = Convert.ToInt32(Console.ReadLine());
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"({(b2 - b1) / (k1 - k2)}; {k1 *  (b2 - b1) / (k1 - k2) + b1})");
}


Cord();