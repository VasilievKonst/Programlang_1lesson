Console.WriteLine("Введите число: ");
String Firstnum = Console.ReadLine();  // Ввод  числа
int Numb1 = Convert.ToInt32(Firstnum); // Преобразование строки в число для числа
if (Numb1 % 2 != 0)        // проверяем условия остатка после деления целого
{
    Console.Write("Является ли число четным: ");
    Console.WriteLine("Нет");
}
else 
{
    Console.Write("Является ли число четным: ");
    Console.WriteLine("Да");
}