// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
void methodArray (string [] array)
{
    string [] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArray[i] = array[i];
            Console.Write(newArray[i] + " ");
    }  
}
void ShowArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + ",");
}
string[] array = { "three", "1313", "Voldemort", "GUF", "=)", "Denmark"};
ShowArray(array);
Console.Write(" -> ");
methodArray(array);

