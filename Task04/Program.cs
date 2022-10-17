Console.WriteLine("Введите первое число: ");
String Firstnum = Console.ReadLine();  // Ввод первого числа
int Numb1 = Convert.ToInt32(Firstnum); // Преобразование строки в число для первого числа
Console.WriteLine("Введите второе число: ");
String Secondnum = Console.ReadLine();  // Ввод второго числа
int Numb2 = Convert.ToInt32(Secondnum); // Преобразование строки в число для второго числа
Console.WriteLine("Введите третье число: ");
String Thirdnum = Console.ReadLine();  // Ввод третьего числа
int Numb3 = Convert.ToInt32(Thirdnum); // Преобразование строки в число для третьего числа
int Max = Numb1;
if (Numb1 > Max) Max = Numb1;
if (Numb2 > Max) Max = Numb2;
if (Numb3 > Max) Max = Numb3;
Console.Write("Max = ");
Console.WriteLine(Max);