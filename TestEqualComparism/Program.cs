Console.WriteLine("Enter a number (1-12),1 for Jan...;");

int month = int.Parse(Console.ReadLine());

#region  ifstatement
// if(month ==1){
//     Console.WriteLine("Jan");
// }

// else if (month ==2){
//     Console.WriteLine("Feb");
// }
// else if (month ==3){
//     Console.WriteLine("Mar");
// }
// else if (month ==4){
//     Console.WriteLine("Api");
// }
// else if (month ==5){
//     Console.WriteLine("May");
// }
// else if (month ==6){
//     Console.WriteLine("Jun");
// }6
// else if (month ==7){
//     Console.WriteLine("July");
// }
// else if (month ==8){
//     Console.WriteLine("Aug");
// }
// else if (month ==9){
//     Console.WriteLine("Sep");
// }
// else if (month ==10){
//     Console.WriteLine("Oct");
// }
// else if (month ==11){
//     Console.WriteLine("Nov");
// }
// else if (month ==12){
//     Console.WriteLine("Dec");
// }

// else
// {
//     Console.WriteLine("Your input is wrong !!")
// }
#endregion

//switch statement..//
switch (month)
{
case 1:Console.WriteLine("Jan");break;
case 2:Console.WriteLine("Feb");break;
case 3:Console.WriteLine("Mar");break;
case 4:Console.WriteLine("Api");break;
case 5:Console.WriteLine("May");break;
case 6:Console.WriteLine("Jun");break;
case 7:Console.WriteLine("Jul");break;
case 8:Console.WriteLine("Aug");break;
case 9:Console.WriteLine("Sep");break;
case 10:Console.WriteLine("Oct");break;
case 11:Console.WriteLine("Nov");break;
case 12:Console.WriteLine("Dec");break;

default:
Console.WriteLine("Your input is wrong");break;

}
