// string? readResult;
// bool validNumber;
// int value;

// do {
//     Console.WriteLine("Enter integer value between 5 and 10 : ");
//     readResult = Console.ReadLine();

//     validNumber = int.TryParse(readResult, out value);

//     if(!validNumber) {
//         Console.WriteLine("Sorry, you entered an invalud number, please try again");
//     }else {
//         if (value < 5 || value > 10) {
//             Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10");
//         }else {
//             Console.WriteLine($"Your input value {value} has been accepted");
//         }
//     }

// }while(value < 5 || value > 10);

// string role = "Administrator|Manager|User";
// string? inputRole;

// bool validInput;

// do {
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User : ");

//     inputRole = Console.ReadLine();

//     if(inputRole == null) {
//         Console.WriteLine("Input role null, please retry");
//         validInput = false;
//         continue;
//     }

//     validInput = role.Contains(inputRole.Trim());
//     if(!validInput) Console.WriteLine($"The role name that you entered, {inputRole} is not valid. Enter your role name (Administrator, Manager, or User)");
// }while(!validInput);

// Console.WriteLine($"Your inpur {inputRole} has been accepted");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString;
int periodLocation;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}