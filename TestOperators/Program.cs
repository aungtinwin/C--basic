
// Console.WriteLine("Operators");

// int x = (2+8)/3*5;
// Console.WriteLine(x);

// int x;
// Console.WriteLine(x); // error//


// int x;
// int y = 2*x;
// Console.WriteLine(y); // error//

// int x;
// int y = 2*9;
// Console.WriteLine(y); // 18// warning//

// int x ;
// x =3;
// Console.WriteLine(x*5-1); 
// The vale of x is 3.

// int x = 100;
// Console.Write("x="); // write is (not next line) //
// Console.WriteLine(x);

// Console.WriteLine(20 + 40); //arithmetic operator// number return type
// Console.WriteLine("Hello" + " " + "World!"); //Concatenation operator// return string type
// Console.WriteLine(1 + "Hello"); // concatenation operator// return string type
// Console.WriteLine("Hello " + 1); // concatenation operator// return string type

// Console.WriteLine("Hello " + 1 +2); // concatenation operator// return string type => "Hello 1" +2 => "Hello 1" + "2" => "Hello 12"
// Console.WriteLine(1+2 + " Hello "); // concatenation operator// return string type => 3 + " Hello "  => "3 Hello "

// int x = 2.5; // error// cannot convert double to int//
// double d= 2.5;
// Console.WriteLine(d); // 2.5//

// double y = 2;
// Console.WriteLine(y); // 2.0// no error// automatically convert 2 int to 2.0 double//

// double myGPA = 5.5;
// int myInt = 10 + myGPA % 2 ; // error// cannot convert double to int//
// Console.WriteLine(myInt); // 11// 5.5%2 = 1.5 => 1 + 10 = 11//


// double avg;
// avg = (9+8) /2.0; // avg = (9+8)/2.0 => 17/2.0 => 8.5//
// Console.WriteLine("avg= " + avg); // 8.5//




// Area of Triangle  
int triangleBase = 10;
int height = 5;
int area = (triangleBase * height) / 2;
Console.WriteLine("Area of Triangle: " + area + " sq units");


// Area Of Circle area.
int radius = 5;
double circleArea = 3.14 * radius * radius;
Console.WriteLine("Area of Circle: " + circleArea + " sq units");


// To convert seconds to hours,minute and second in format (01:02:05).
int seconds = 3725;
int hours = seconds / 3600;
// Console.WriteLine("Hours: " + hours);

int minutes = (seconds % 3600) / 60;
int remainingSeconds = seconds % 60;
Console.WriteLine("Time: " + hours + ":" + minutes + ":" + remainingSeconds);


