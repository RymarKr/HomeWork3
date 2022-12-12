//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
       
       Console.WriteLine("Введите пяти значное число: ");
bool isParsed = false;
int number = 0;
    while (isParsed == false)
    {
    isParsed = int.TryParse(Console.ReadLine(), out number);
        if (isParsed == false)
        {
        Console.WriteLine("Пиши пятизначное число !");
        }
    }
int num = number;      
       
void Palindrom()
        {
        int num1 = num / 10000 % 10;
        int num2 = num / 1000 % 10;
        int rev1 = num / 10 % 10;
        int rev2 = num % 10;
        int nul = num / 10000;

            if (nul < 1 || nul > 9){
            Console.WriteLine("Пиши пятизначное число !");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(num + " - Число является палиндромом");
            }
            else{
            Console.WriteLine(num + " - Число не является палиндромом");
            }
    }
                Palindrom();