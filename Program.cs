//ari_conway
//Datatypes in C#

short aShortMinVal = short.MinValue;
short aShortMaxVal = short.MaxValue;

Console.WriteLine("aShortMinVal = " + aShortMinVal);
Console.WriteLine("aShortMaxVal = " + aShortMaxVal);
Console.WriteLine(aShortMinVal + "<= aShortNum <= " + aShortMaxVal);

Int64 aLongMinVal = Int64.MinValue;
Int64 aLongMaxVal = Int64.MaxValue;

Console.WriteLine("aLongMinVal = " + aLongMinVal);
Console.Write("aShortMinVal = " + aShortMinVal);
Console.WriteLine(aLongMinVal + "<= aLongNum <= " + aLongMaxVal);

//arithemtic operators: + - * / %

int a = 10;
int b = 5;
int c = 3;

int sum_ab = a + b; //10 + 5 = 15
int diff_ab = a - b; //10 - 5 = 5
int diff_ba = b - a; //5 - 10 = -5
int product_ab = a * b; //10 * 5 = 50
int quotient_ab = a / b; //10 / 5 = 2
int quotient_ac = a / c; //10 / 3 = 3.33333
int remainder_ab = a % b; //remainder of 10 / 5 = 0
int remainder_ac = a % b; //remainder of 10 / 3 = 1

Console.WriteLine("Hello, we are calculating your final average.");
Console.Write("Please enter your midterm grade: ");

float midTermGrade = Console.ReadLine();