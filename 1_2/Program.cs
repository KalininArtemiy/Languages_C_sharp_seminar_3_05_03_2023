int count_numbers(int num)
{
  int amount = 1;
  for (int i = 1; i <= num; i++)
  {
    amount = amount * i;
  }
  return amount;
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(count_numbers(A));
