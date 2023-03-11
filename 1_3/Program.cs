void Massiv(int leght)
{
int[] R = new int[leght];
for (int i=0; i<leght; i++)
  {
  R[i] = new Random().Next(10);
  Console.WriteLine();
  Console.WriteLine(R[i]);
  }
}

Massiv(int.Parse(Console.ReadLine()!));