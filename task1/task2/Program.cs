Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2);
