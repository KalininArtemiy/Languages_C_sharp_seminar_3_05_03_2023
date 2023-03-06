int number_degree(int number, int degree)
{
  int result = 1;
  for (int i = 0; i < degree; i++)
  {
    result *= number;
  }
  return result;
}
Console.WriteLine(number_degree(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));