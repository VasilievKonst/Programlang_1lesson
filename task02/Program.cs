Console.WriteLine("Введите первое число: ");
String Firstnum = Console.ReadLine();  // Ввод первого числа
int Numb1 = Convert.ToInt32(Firstnum); // Преобразование строки в число для первого числа
Console.WriteLine("Введите второе число: ");
String Secondnum = Console.ReadLine();  // Ввод второго числа
int Numb2 = Convert.ToInt32(Secondnum); // Преобразование строки в число для второго числа
if (Numb1 > Numb2) // сравниваем числа
{
    Console.Write("Max = ");
    Console.WriteLine(Numb1);
}
if (Numb2 > Numb1) // сравниваем числа
{
    Console.Write("Max = ");
    Console.WriteLine(Numb2);
}
else
{
    Console.WriteLine("Числа равны!"); // если вдруг числа будут равны
}