// // Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
//Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"  - если есть строка "qwerty" , то для нее есть некоторый вспомог функционал
//            012  - если нам нужно обратиться к конкрт символу строки, делаем отсчитывая позицию символа с 0
//s [3] =  r   - указываем идентификатор

string Replace(string text, char oldValue, char newValue)  // метод принимает строку и символы  которые нужно заменить, char - symbol
{
    string result = String.Empty;

    int length = text.Length;   // text.Length выдаст длину строки 
    for( int i = 0; i < length; i++)  // пробегаемся от 0 символа до конца наше строки
    {
      if(text[i] == oldValue)  result = result + $"{newValue}";  //делая следующее, если текст [i] сопал с тем, что нам нужно заменить, то  в результат нужно положить новое значение строки 
      else result = result + $"{text[i]}"; // если совпадений нет, то в резалт идет текущий символ
    }

    return result;
}

string newText = Replace(text, ' ', '|');  // - это |
Console.WriteLine(newText);
// пробелы заменили, теперь нужно заменить к -К, с - С;

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);