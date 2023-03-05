int count_numbers(int num)
{
  int amount = 0;
  for (int i = 1; num > 0; i++)
  {
    num = num / 10;
    amount = i;

  }
  return amount;
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(count_numbers(A));