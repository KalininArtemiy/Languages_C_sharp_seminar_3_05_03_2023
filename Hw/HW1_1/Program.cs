double number_degree(double number, double degree)
{
  double result = 1;
  if (degree == 0) return result;
  else if (degree > 0)
  {
    for (int i = 0; i < degree; i++)
    {
      result *= number;
    }
  }
  else if (degree < 0)
  {
    for (int i = 0; i > degree; i--)
    {
      result *= number;
    }
    result =  1 / result;
  }
  return result;
}
Console.WriteLine(number_degree(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())));