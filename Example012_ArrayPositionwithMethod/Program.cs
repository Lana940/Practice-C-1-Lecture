//решение задачи по нахождению позиции нумжного нам элемента массива с использованием метода
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length; //определяем кол-во ел
    int index = 0;
    int position = -1; //переменная для сохранения позиции если if(collection[index] == find), если искомого элемента нет в массиве, то будет выводить позицию -1, т.е ясно что такой элемент не сущ-ет в массиве

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
    
}
int[] array = new int[10]; //создай новый массив из 10 елементов

FillArray(array);
array[4] = 4; //принудительно добавли для проверки, если у нас несколько 4-к в массиве
array[6] = 4;
PrintArray(array);
Console.WriteLine(); 

int pos = IndexOf(array, 4); //в качестве аргумента наш массив и 4 из него
Console.WriteLine(pos);