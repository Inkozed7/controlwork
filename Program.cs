void PrintArray(string[] array)
{   
    int n = array.Length;
    Console.Write("[");
    for(int i=0;i<n;i++)
    {
        if(array[i]==null) continue;
        if(i==0) Console.Write(array[i]);
        else Console.Write(", "+array[i]);
    }
    Console.Write("]");
};

string[] FilterArray(string[] array)
{   
    int size = array.Length;
    string[] result = new string[size];
    int index = 0;
    int index_result = 0;

    while (index<size)
    {  
        if(array[index].Length<=3)
        {
            result[index_result]=array[index];
            index_result++;
        }
        index++;
    } 
    return result;
};

string[] array = new string[]
{"Russia","Inkozed","Ekb"};
PrintArray(array);
Console.Write("->");
PrintArray(FilterArray(array));