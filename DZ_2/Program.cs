// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

  int sum(int N)
  {
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = N - N % 10;
      result = result + (N - advance);
      N = N / 10;
    }
   return result;
  }

int Sum = sum(N);
Console.WriteLine("Сумма цифр в числе: " + Sum);
