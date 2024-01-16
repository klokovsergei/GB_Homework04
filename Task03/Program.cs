// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

//методы
int[] CreateArr(int size) //создание и наполнение массива случайными числами
{
    int[] nums = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(10, 100);
    }
    return nums;
}

void ReversArr(int[] nums)
{
    int changeNumber;
    for (int i = 0; i < nums.Length / 2; i++)
    {
        changeNumber = nums[i];
        nums[i] = nums[nums.Length - 1 - i];
        nums[nums.Length - 1 - i] = changeNumber;
    }
}

void ShowArr(int[] nums) // метод для вывода массива в консоль
{
    Console.WriteLine($"Массив: [ {string.Join(", ", nums)} ]");
}

//основная часть - метод Main
Console.Write("Укажите размер одномерного целочисленного массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArr(sizeArr);
ShowArr(array);

Console.WriteLine("Вызываю метод ReversArr.");
ReversArr(array);
ShowArr(array);
