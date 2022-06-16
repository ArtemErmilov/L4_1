// Вид 1

void Method1() // Создание функции тип 1
{
    Console.WriteLine("Автор....");
}

/*Method1(); // Вызов функции*/

// Вид 2

void Method2(string msg) // Создание функции тип 2
{
    Console.WriteLine(msg);
}

/* Method2("Автор Ермилов Артём"); // Вызов функции  тип 2*/
// Аналогично можно также записать:

/* Method2(msg: "Автор Ермилов Артём"); // Вызов функции  тип 2*/

void Method21(string msg, int count)
{
    int i = 0;

    while (i < count)
    {
        Console.WriteLine(msg + i);
        i++;
    }

}

/*Method21("Текст ",4); // Вызов функции  тип 21*/

// Аналогично можно также записать:

/*Method21(msg: "Текст ",count:4); // Вызов функции  тип 21*/
/*Method21(count:4, msg: "Новый тест "); // Вызов функции  тип 21*/


// Вид 3.

int Method3() //Создание функции тип 3
{
    return DateTime.Now.Year;
}

/*int year = Method3();
console.WriteLine(year);Вызов функции  тип 3 */

//Вид 4

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result=result+text;
        i++;
    }

return result;

}*/

string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }

    return result;

}

/*string res = Method4(10, "asdf "); //Вывод функции 4
Console.WriteLine(res);*/

//Вывод таблици умнажения на экран

/*for (int i = 2; i <=10; i++)
{
 for (int j = 2; j <=10; j++)
 {
     Console.WriteLine($"{i} x {j} = {i*j}");
 }   
 Console.WriteLine(" ");
} */


/*Условие задачи: 
Дан текст. В тексте нужно все пробелы заменить черточками,
 маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”. */

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего"
               + "милогоВинценгероде, вы бы взяли приступом согласие"
               + "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

/*string newText = Replace( text,' ','|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace( text,'к','К');
Console.WriteLine(newText);
Console.WriteLine();*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // Создание функции вывода значений на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

void SelectionSort(int[] array) // Создание функции сортировки
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if( array[j]<array[minPosition]) minPosition=j;
        }

        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);