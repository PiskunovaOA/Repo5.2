//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

double[] array = new double[10]; 

double max = array[0];
double min = array[0];


for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine(array[i] + " ");
}


for (int i = 1; i < array.Length; i++)
{
if (array[i] > max)
    {
    max = array[i];
    }
if (array[i] < min)
    {
    min = array[i];
    }
}
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным элементом {max} " +
                      $"и минимальным элементом {min} массива равна: {diff}");
