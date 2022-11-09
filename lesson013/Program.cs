int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 10);
    Console.Write(" " + Output (i) + " ");
 }
Console.Write("]");

int  Output(int a)
{
    return numbers[a];
}

