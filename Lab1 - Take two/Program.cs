//Användarens textsträng
Console.Write("Skriv in valfri sekvens: ");
string userInput = Console.ReadLine();

// Konverterar anvnändarens sträng till en char array
char[] userInputToChar = userInput.ToCharArray();

string firstOcc = "", secondOcc = "";
string firstPart = "";
string singleDigit = "";

for (int i = 0; i < userInput.Length; i++)
{
    if (char.IsDigit(userInput[i]))
    {
        firstOcc = userInput.Substring(userInput.IndexOf(userInputToChar[i], 0));
        secondOcc = userInput.Substring(userInput.IndexOf(userInputToChar[i], 1));
        singleDigit = secondOcc[i].ToString();
        break;
    }
}

string[] firstOccParts = firstOcc.Split(secondOcc);

firstPart += firstOccParts[0] + singleDigit;
secondOcc += secondOcc - int.Parse(singleDigit);
Console.WriteLine($"FP: {firstPart}\nSP: {secondOcc}");