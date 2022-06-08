int [] array = {11,22,33,44,55,16,17,18,44};

int n = array.Length; //array.Length;
int find = 44;

int index = 0;

while (index<n)
{
    if (array[index]==find )
    {
        Console.WriteLine(index);
        break;

    }
    
    index++;
}