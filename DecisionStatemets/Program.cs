
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Decision");
// # region finished


// double gpa = 5;
// if(gpa<2)
// {
// Console.WriteLine("You application is denied");
// }


// double gpa = 1;
// if(gpa<2)
// {
// Console.WriteLine("You application is denied");
// }
// else
// {
// Console.WriteLine("Welcome to the university");
// }




// int grade = 65;
// if(grade>=90)
// {
//     Console.WriteLine("A");
// }
// else if(grade>=80)
// {
//     Console.WriteLine("B");
// }
// else if(grade>=70)
// {
//     Console.WriteLine("C");
// }
// else
// {
//     Console.WriteLine("D");
// }
// #endregion

//========================//




// int age =15; // static value binding //


// //dynamic value binding
// int age;
// Console.Write("Enter your age");
// string ageString = Console.ReadLine();
// age = int.Parse(Console.ReadLine());

// if(age>=18)
// {
//     Console.WriteLine("You can vote");
// }
// else
// {
//     Console.WriteLine("You can't vote");
// }

//========================//

// int grade;
// Console.Write("Enter your marks");
// string gradeString = Console.ReadLine();
// grade = int.Parse(Console.ReadLine());

// if (grade >= 95)
// {
//     Console.WriteLine("A+");
// }
// else if (grade >= 90)
// {
//     Console.WriteLine("A");
// }
// else if (grade >= 80)
// {
//     Console.WriteLine("B");
// }
// else if (grade >= 60)
// {
//     Console.WriteLine("C");
// }
// else
// {
//     Console.WriteLine("D");
// }


// Homework //

// int num;
// Console.Write("Enter  Number");
// num = int.Parse(Console.ReadLine());

// if(num%2==0)
// {
//     Console.WriteLine("Ever Number")

// } 
// else
// {
//     Console.WriteLine("Odd Number")
// };

//========================//
// ExamResult //Homework//
int Myanmark, Engmark, Mathmark, PhyMark, Chemmark, Biomark;
Console.Write("Enter Myanmark");
Myanmark = int.Parse(Console.ReadLine());

Console.Write("Enter Engmark ");
Engmark = int.Parse(Console.ReadLine());

Console.Write("Enter Mathmark ");
Mathmark = int.Parse(Console.ReadLine());

Console.Write("Enter PhyMark");
PhyMark = int.Parse(Console.ReadLine());

Console.Write("Enter Chemmark ");
Chemmark = int.Parse(Console.ReadLine());

Console.Write("Enter BioMark");
Biomark = int.Parse(Console.ReadLine());

if  (Myanmark >= 40 && Engmark >= 40 && Mathmark >= 40 && PhyMark >= 40 && Chemmark >= 40 && Biomark >= 40)
{
    Console.Write("Pass");
    if(Myanmark >= 65 && Engmark >= 65 && Mathmark >= 65 && PhyMark >= 65 && Chemmark >= 65 && Biomark >= 65 )
    {
        Console.Write("-Credit");
    }
    if (Myanmark >= 80 || Engmark >= 80 || Mathmark >= 80 || PhyMark >= 80 || Chemmark >= 80 || Biomark >= 80 )
    {
        Console.Write("-Distinction");
    }
    Console.WriteLine();

}

else
{
    Console.WriteLine ("Fail");
}


/// my test code//

// if (Myanmark >= 80 || Engmark >= 80 || Mathmark >= 80 || PhyMark >= 80 || Chemmark >= 80 || Biomark >= 80 )
// {
//     Console.WriteLine("Distinction");
// }
// else if (Myanmark >= 65 && Engmark >= 65 && Mathmark >= 65 && PhyMark >= 65 && Chemmark >= 65 && Biomark >= 65 )
// {
//     Console.WriteLine("Credit");
// }

// else  (Myanmark >= 40 && Engmark >= 40 && Mathmark >= 40 && PhyMark >= 40 && Chemmark >= 40 && Biomark >= 40)
// {
//     Console.WriteLine("Pass");
// }

// else if (Myanmark < 40 || Engmark < 40 || Mathmark < 40 || PhyMark < 40 || Chemmark < 40 || Biomark < 40)
// {
//     Console.WriteLine("Fail");

// }
// else 
// {
//     Console.WriteLine("You need to write between 1 to 100");
// }


