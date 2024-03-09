// See https://aka.ms/new-console-template for more information
//Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] studentsG1 = new string[] { "Sage", "Jett", "Phoenix", "Reyna", "Yoru" };
string[] studentsG2 = new string[] { "Harbor", "Astra", "Deadlock", "Gekko" };

Console.WriteLine("Would you like to vew student group 1 or 2?");

int i = int.Parse(Console.ReadLine());

foreach (string student in studentsG1)
{
    if (i == 1)
        continue;
    Console.WriteLine(student + " ");
}

foreach (string student in studentsG2)
{
    if (i == 2)
        continue;
    Console.WriteLine(student + " ");
}