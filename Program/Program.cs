Console.WriteLine("Сколько элементов массива Вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

if (size <= 0)
{
    Console.WriteLine();
    Console.Write("Число отрицательное либо имеет нулевое значение.");
}

else if (size > 0)
{
string[] array1 = new string[size];
void FirstArray(string[] array1)
{
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array1[i] = element;
}
}

string[] array2 = new string[size];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int j = 0; j < array1.Length; j++)
    {
    if(array1[j].Length <= 3)
        {
        array2[count] = array1[j];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

FirstArray(array1);
SecondArray(array1, array2);
Console.WriteLine();
Console.WriteLine("Массив из строк длина которых либо меньше либо равна 3 символа ");
PrintArray(array2);
}
