// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

int[] array = new int[10];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 5);
    Console.Write($"{array[i] + " "}");
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
        sum += array[i];
}
Console.WriteLine();
Console.WriteLine("The sum of elements in odd positions is equal to {0}", sum);