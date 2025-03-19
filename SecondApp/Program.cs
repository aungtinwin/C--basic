
Console.WriteLine("Variable,Data Type and Operators");

int age; // variable declaration//
age = 25; // value assign //
Console.WriteLine(age);


int myAge = 100; // variable declaration and value assign //
Console.WriteLine(myAge);


// age = 10.5  Error //
// age = "ten" // Error //
//  age = null; 
// age = true;

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);

int num = int.MaxValue;
Console.WriteLine(num);

//  int num = int.MaxValue+1;
//  Console.WriteLine(num);

int max = 2147483647;
int result1 = max + 1;
Console.WriteLine("max=" + max);
Console.WriteLine("max +1="+ result1);

int min = -2147483648;
int result2 = min-1;
Console.WriteLine("min=" + min);
Console.WriteLine("min-1="+ result2);
