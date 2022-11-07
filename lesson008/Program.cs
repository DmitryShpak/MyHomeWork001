Console.WriteLine("Введите пятизначное число: ");
string n = Console.ReadLine();

void Number(string n)
{
  if (n[0]==n[4] && n[1]==n[3])
  {
    Console.WriteLine("Число палиндром.");
  }
  else 
  Console.WriteLine("Число не палиндром.");
}
if (n!.Length == 5)
{
  Number(n);
}
else Console.WriteLine("Введено не пятизначное число");