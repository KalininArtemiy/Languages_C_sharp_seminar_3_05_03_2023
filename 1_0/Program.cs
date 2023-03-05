int sum_to_a(int a)
{
  int sum = 0;
  for (int i = 0; i <= a; i++)
  {
    sum = sum + i;
  }
  return sum;
}
Console.WriteLine(sum_to_a(int.Parse(Console.ReadLine())));