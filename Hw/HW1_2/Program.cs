int sum(int number)
{
  int result = 0;
  while (number>0)
  {
    result += number % 10;
    number = number/10;
  }
  return result;
}
Console.WriteLine(sum(int.Parse(Console.ReadLine())));