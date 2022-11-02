// Нахождение большего из двух чисел
Console.WriteLine("Введите первое число");
string Sa = Console.ReadLine();
Console.WriteLine("Введите второе число");
string Sb = Console.ReadLine(); 
int a = int.Parse(Sa);
int b = int.Parse(Sb);
if (a>b)
{
    Console.WriteLine("Первое число больше второго");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}