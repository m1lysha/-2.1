try
{
    Console.Write("Введите A: "); int A = int.Parse(Console.ReadLine());
    Console.Write("Введите B: "); int B = int.Parse(Console.ReadLine());
    Console.Write("Введите C: "); int C = int.Parse(Console.ReadLine());
    if (A % 2 == 0) Console.WriteLine("A чётное"); else if (B % 2 == 0) Console.WriteLine("B чётное");
    if ((A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0)) Console.WriteLine("Все числа кратны трём");
    else Console.WriteLine("Одно или все числа не кратны трём");
}
catch
{
    Console.WriteLine("Введите верно!");
}