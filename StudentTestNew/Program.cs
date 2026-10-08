using StudentLibrary;


Student student1 = new Student();
Student student2 = new Student("Jane Doe", 18);

student1.Display();
student2.Display();

student1.GetOlder();
student2.GetOlder();

Console.WriteLine("Confirming ages have increased: ");
student1.Display();
student2.Display();

