
Console.Clear();
Console.WriteLine("a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b=");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b >= max)
{
    Console.Write($"max = {b} min = {a}");
}
else
{
    Console.Write($"max = {a} min = {b}");
}