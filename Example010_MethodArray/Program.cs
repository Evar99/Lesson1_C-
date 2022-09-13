// ищем, на какой позиции (индекс элемента) стоит число, которое мы ищем


int[] array = { 1, 20, 33, 18, 51, 63, 17, 18 };
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если условие уже единожды выполнилось, больше ничего делать не нужно
    }
    //index = index + 1;
    index++;
}