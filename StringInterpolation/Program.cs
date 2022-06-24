// string interpolation = allows us to insert variables into a string literal
//                        precede a string literal with $
//                        {} are placeholders

String firstName = "Brit";
String lastName = "Campos";
int age = 21;

Console.WriteLine($"Hello {firstName} {lastName}.");
Console.WriteLine($"You are {age, 10} years old.");

Console.ReadKey();