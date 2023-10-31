//نیما فدوی
//فیبوناچی
int a = 0, b = 1, c;
Console.WriteLine("please enter a number");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{a}\t{b}\t");
for (int i = 2; i <= n; i++)
{
    c = a + b;
    Console.Write($"{c}\t");
    a = b;
    b = c;
}
