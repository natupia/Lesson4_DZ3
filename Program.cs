// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreatArray(int size)
{
    int[] massiv = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(1, 9);
    }
    return massiv;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " " );
    }
}

int[] array = CreatArray(8);
PrintArray(array);
