// Вид 1 - ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); // vyzov methoda

// Вид 2  - принимает что-то, но ничего не возвращает

void Method2(string msg)  // какие то аргументы метода
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21(msg: "текст", count: 4);  //именованные аргументы

//Вид 3 что то возвращает, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид 4  что-то принимает и что-то возвращает 

// string Method4(int count, string text)    //( есть строка, которую надо напечатать count раз)
// {
//     int i = 0;
//     string result = String.Empty;  // переменная куда кладем конечный результат, и в нее изначально нужно положить какое то значение 0 или пусто в данном случае

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Zs");
// Console.WriteLine(res);

// то же самое с циклом for

string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i ++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "zt");
Console.WriteLine(res);

//таблица умножения

for( int i = 2; i <= 10; i ++)
{
    for ( int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = { i * j}");
    }
    Console.WriteLine();
}
