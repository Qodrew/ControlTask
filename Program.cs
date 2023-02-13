System.Console.WriteLine("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
string[] arrayTask = new string[sizeArray];
string[] arrayAnsver = new string[sizeArray];

PrintArray(CreateArray(arrayTask));
PrintArray(CreateArrayAnswer(arrayTask));

string[] CreateArray(string[] arrayTask) {
    for(int i = 0; i < arrayTask.Length; i++) {
        Console.Write($"Введите {i+1} элемент массива: ");
        arrayTask[i] = Console.ReadLine();
    }
    return arrayTask;
}

void PrintArray(string[] array) {
    int count = array.Length;
    for (int i = 0; i < count; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] CreateArrayAnswer(string[] array) {
    int j = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3 ) {
            arrayAnsver[j] = array[i];
            j++;
        }
    }
    return arrayAnsver;
}
