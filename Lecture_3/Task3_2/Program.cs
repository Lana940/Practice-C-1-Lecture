//  Упорядочить массив

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int [] array)  // этап печати массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }

    Console.WriteLine();
}

void SelectionSort( int [] array) // 2 етап сортировки
{

    for (int i = 0; i < array.Length - 1; i++)   //array.Length -1 - искуственно отнимаем 1, тк дальше j = i +1 и оно даст общее кол-во элементов
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)     //этот блок кода ищет максм елемент, 
        {
            if(array[j] < array[minPosition]) minPosition = j;   

        }
            
        int temporary = arr[i];           // а тут происходит обмен, как в блок схемах последнего урока
        array [i] = array[minPosition];
        array[minPosition] = temporary;
    }

}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);