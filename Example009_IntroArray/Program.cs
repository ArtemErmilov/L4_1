// Нахождение масимума из 9 чисел

int Max(int arg1, int arg2, int arg3) // Создание функции
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {11,22,33,44,15,26,17,38,79};
//array[0]=12;
//Console.WriteLine(array[0]);


    int max1 = Max(array[0],array[1],array[2]);
    int max2 = Max(array[4],array[5],array[6]);
    int max3 = Max(array[7],array[8],array[9]);
    int max = Max(max1,max2,max3);

Console.WriteLine(max);
