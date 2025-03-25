Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());

// switch(num)
// {
//  case <0:                    Console.WriteLine("Negative");break;
//  case  0:                    Console.WriteLine("Zero");break;
//  case >0 and <100 :          Console.WriteLine("Small Positive");break;
//  case >=100 and <10000 :     Console.WriteLine("Medium Positive");break;
//  case >=10000  :             Console.WriteLine("Large Positive");break;

// }
// Console.WriteLine("End Program");


// string text = " ";
// switch(num)
// {
//  case <0:                text ="Negative";break;
//  case  0:                text ="Zero";break;
//  case >0 and <100 :      text ="Small Positive";break;
//  case >=100 and <10000 : text ="Medium Positive";break;
//  case >=10000  :         text ="Large Positive";break;

// }
// Console.WriteLine("Your result is :"+ text);


string text = num switch
{
    <0                 => "Negative",
    0                  => "Zero",
    >0 and <100        => "Small Positive",
    >=100 and <10000   => "Medium Positive",
    >=10000            => "Large Positive"

};
Console.WriteLine(text);

Console.WriteLine("End Program");