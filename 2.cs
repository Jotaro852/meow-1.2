
using System;
using System.Collections.Generic; // использовать List<T>
class work_1_2
{
    static void Main()
    {
        List<float> array = new List<float>(); // создание динамического, пустого массива
        float sum = 0; // сумма
        float multiplication = 1; // умножение
        
        while (true) // бесконечная функция
        {
            Console.Write("Введите число: "); // вывод инфы
            float number = float.Parse(Console.ReadLine()); // число пользователя
            if (number == 0) // елси число = 0
            {
                break; // конец ф-ии
            }
            sum += number; // складываем 
            multiplication *= number; // умножаем
            array.Add(number); // добавляем число в массив
        }
        float average = sum / array.Count; // вычисление среднего. Count - количества элементов
        
        var str = string.Join(" ", array); // var - переменная без какого-либо типа данных. String.Join – 
метод принимающий разделитель        
        Console.WriteLine(str); // вывод str
        Console.WriteLine($"Сумма: {sum} \t Произведение: {multiplication} \t Среднее значение: 
{average}"); // вывод мин числа
    }
} 