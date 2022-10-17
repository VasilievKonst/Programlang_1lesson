Console.WriteLine("Введите число N: ");
String Firstnum = Console.ReadLine();  // Ввод  числа
int n = Convert.ToInt32(Firstnum); // Преобразование строки c числом N для числа nd
Console.WriteLine("Четные числа в заданном цикле: ");
for (int a = 1; a < n; a++ )
{
    if (a % 2 == 0)
    {
            Console.WriteLine(a);
    }
}
