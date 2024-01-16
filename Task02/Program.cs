// Задайте массив заполненный случайными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

//блок с методами
void ShowArr(int[] nums) //показывает массив целых чисел
{
    Console.Write($"\nМассив:\n[ " + string.Join(", ", nums) + " ]\n");
}

int[] FillArr(int size)
{
    int[] nums = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(100,1000);
    }
    return nums;
}

int CountEvenNumbers(int[] nums)
{
    int count = 0;
    foreach (int s in nums)
    {
        count += (s % 2 == 0)? 1 : 0;
    }
    return count;
}

//основной блок Main
Console.Write("Укажите размерность массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = FillArr(sizeArr);
ShowArr(array);
Console.WriteLine($"В массиве из {sizeArr} элементов кол-во чётных чисел равно {CountEvenNumbers(array)}.");
