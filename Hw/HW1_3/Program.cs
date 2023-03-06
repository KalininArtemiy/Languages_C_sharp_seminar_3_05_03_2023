int[] new_massive(int Lenght, int Min, int Max)
{
  int[] array = new int[Lenght];
  Random random = new Random();
  for (int i = 0; i < Lenght; i++)
  {
    array[i] = random.Next(Min, Max+1);
  }
  return array;
}

void print(int[] array)
{
  Console.Write("[ ");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write("]");
}
int[] arr = new_massive(8,1,10);
print(arr);