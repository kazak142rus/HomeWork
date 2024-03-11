// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

void Main(){
int M = readNumber("Введите число M");
int N = readNumber("Введите число N");
printNaturalNumber(M,N);
printNaturalNumber2(M,N);
}

int readNumber(string msg){
    Console.WriteLine(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
 
void printNaturalNumber(int number1, int number2){
    if(number1>number2) return;
printNaturalNumber(number1,number2 -1);
Console.Write(number2 + " ");
}
void printNaturalNumber2(int number1, int number2){
if(number1<number2) return;
Console.Write(number1 + " ");
printNaturalNumber2(number1 -1, number2);
}

Main();
