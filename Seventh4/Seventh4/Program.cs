using System.Globalization;

namespace Seventh4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // ЗАДАЧА 1 Запрос на ввод четырех чисел
            Console.WriteLine("1 number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2 number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("4 number:");
            double num4 = Convert.ToDouble(Console.ReadLine());

            // Вычисление среднего значения
            double average = (num1 + num2 + num3 + num4) / 4;// общее колво чисел дели на 4

            // Вывод результата
            Console.WriteLine($"Среднее значение введенных чисел: {average}");
            */


            /*
            // ЗАДАЧА 2
            
            Console.WriteLine("Простой калькулятор");

            // Ввод первого числа
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Ввод второго числа
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Выбор операции
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. остаток (%)");

            Console.Write("Введите номер операции: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result;

            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case 4:
                    // Проверка на деление на ноль
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }

            // Задержка перед закрытием консоли
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
            */


            //ЗАДАЧА 3 - НЕТ

            /*
            //ЗАДАЧА 4
            Console.WriteLine("Введите путь");
            string str = Console.ReadLine();
            string[] parts = str.Split('/');
            Console.WriteLine(parts[parts.Length - 1]);
            */


            /*
           //ЗАДАЧА 5

          Console.WriteLine("Введите предложение:");
          string input = Console.ReadLine();

          string longestWord = FindLongestWord(input);
          Console.WriteLine("Самое длинное слово: " + longestWord);
      }

      static string FindLongestWord(string sentence)
      {
          // Определяем символы-разделители
          char[] delimiters = { ' ', ',', '.', '!', '?', ';', ':' };

          // Разделяем строку на слова
          string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

          string longestWord = "";

          // Цикл для поиска самого длинного слова
          for (int i = 0; i < words.Length; i++)
          {
              // Если текущее слово длиннее, чем текущее самое длинное слово, обновляем
              if (words[i].Length > longestWord.Length)
              {
                  longestWord = words[i];
              }
          }

          return longestWord;
          */

            /*
            // ЗАДАЧА 6 Пример массивов
            int[] array1 = { 1, 17, 8, 3 };
            int[] array2 = { 7, 9, 11, 2 };

            // Проверка на равенство размеров массивов
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Ошибка: Массивы должны быть одной длины!");
                return;
            }

            // Создание результирующего массива
            int[] resultArray = new int[array1.Length];

            // Перемножение массивов
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            // Вывод результата
            Console.WriteLine("Результат перемножения массивов:");
            Console.WriteLine(string.Join(", ", resultArray));
            */

            /*
            // ЗАДАЧА 7 
            int[] numbers = new int[4];

            Console.WriteLine("Введите 5 чисел:");

            // Ввод 5 чисел
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Ищу максимальное и минимальное числа (maxus - максимальное, minus - минимальное)
            int maxus = numbers[0];
            int minus = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxus)
                {
                    maxus = numbers[i];
                }

                if (numbers[i] < minus)
                {
                    minus = numbers[i];
                }
            }

            // Вывод результата
            Console.WriteLine($"Максимальное число: {maxus}");
            Console.WriteLine($"Минимальное число: {minus}");
            */

            /*
            // ЗАДАЧА 8
            Console.Write("Введите количество уровней: ");
            int levels = int.Parse(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                // Выводим пробелы для выравнивания
                for (int j = 1; j <= levels - i; j++)
                {
                    Console.Write(" ");
                }

                // Выводим числа
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Переход на новую строку
                Console.WriteLine();
                */

            /*
            // 2 ЧАААААСТЬ 1 ЗАДАЧА
            // Max число для таблицы
            int maxNumber = 9;

            for (int i = 1; i <= maxNumber; i++)
            {
                for (int j = 1; j <= maxNumber; j++)
                {
                    //Выводим результат
                    Console.WriteLine($"{i} x {j} = {i * j}\t");
                }
                // Новая строка после каждой строки таблицы
                Console.WriteLine();
            */


            /*
            // 4 ВАРИАНТ
            // Объявление переменных
            double num1, num2, num3, num4, average;

            // Запрос ввода от пользователя
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите четвертое число:");
            num4 = Convert.ToDouble(Console.ReadLine());

            // Вычисление среднего значения
            average = (num1 + num2 + num3 + num4) / 4;

            // Вывод результата
            Console.WriteLine($"Среднее значение: {average}");
            */





        }
    }
}
            




            
        
    

              






              



   


            
    







