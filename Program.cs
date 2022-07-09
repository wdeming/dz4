// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void MyPow (int a, int b){
    int result = a;
    for (int i = 1; i < b; i++){
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " +result);
}
MyPow(3,5);
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void FindSum(int number){
    int first = number;
    int result = 0;
    for (int i = 0; number > 0; i++){
        i = number % 10;
        result = result + i;
        number = number / 10;
    }
    Console.WriteLine("Сумма числа " + first + " = " + result);
}
FindSum(235);


// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int[] ArrayValue (int arraySize){
    int[] array = new int[arraySize];
    Random value = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = value.Next(-50,50);
    }
    return array;
}

void SortArra(int[] array){
    int temp = 0;

    Console.Write("Было [");
    for (int j = 0; j < array.Length; j++){
        Console.Write(j == array.Length-1 ? array[j] : $"{array[j]}, ");
    }
    
    Console.Write("] Стало после сортировки [");
    for(int i = 0; i< array.Length; i++){
        for(int k = i+1; k < array.Length; k++){
            if (Math.Abs(Convert.ToInt32(array[i])) > Math.Abs(Convert.ToInt32(array[k])))
            {
                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }
        }
        Console.Write(i == array.Length-1 ? array[i] : $"{array[i]}, ");
    }
    Console.Write("]");
}

int arraySize = 8;
int[] array = ArrayValue(arraySize);
SortArra(array);