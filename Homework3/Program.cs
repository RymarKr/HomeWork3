       
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