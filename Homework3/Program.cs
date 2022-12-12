// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125    

       Console.WriteLine("Введите число: ");
bool isParsed = false;
int number = 0;
    while (isParsed == false)
    {
    isParsed = int.TryParse(Console.ReadLine(), out number);
        if (isParsed == false)
        {
        Console.WriteLine("Пиши число !");
        }
    }
int num = number; 

void PrintEvenNumbers(int num) {
   Console.WriteLine("Числа кубов от 1 до " + num + ":");
   for(int i = 1; i <= num; i++)
   Console.WriteLine(i * i * i);
}
PrintEvenNumbers(num);