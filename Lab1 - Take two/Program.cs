// While - loop med bool för att enkelt testa min kod
using System;

bool closeProgram = false;
while (!closeProgram)
{

    // Användarens textsträng
    Console.Write("Skriv in valfri sekvens: ");
    string userInput = Console.ReadLine();

    // Används för att ge platshållar-arrayerna rätt index.
    int inputIndex = 0;
    foreach (char c in userInput)
    {
        inputIndex++;
    }

    // Konverterar anvnändarens sträng till en char array
    char[] userInputToChar = userInput.ToCharArray();

    // Platshållar-arrayer
    char[] digits = new char[inputIndex];
    char[] others = new char[inputIndex];

    // Sorterar alla karaktärer till rätt array
    for (int i = 0; i < userInputToChar.Length; i++)
    {
        if (char.IsDigit(userInputToChar[i]))
        {
            digits[i] = userInputToChar[i];
        }
        else
        {
            others[i] = userInputToChar[i];
        }
    }

    bool dubblett = false;
    string digitOne = "", digitTwo = "";

    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] * 2 == 98)
        {
            digitOne = digits[i].ToString();
            digitTwo = i.ToString();
            dubblett = true;
        }
    }
    Console.WriteLine($"{dubblett} Tal 1 {digitOne} Tal 2 {digitTwo}");
    // Skapar en sträng av alla siffror
    string numbers = "";

    for (int i = 0; i < userInputToChar.Length; i++)
    {
        numbers += digits[i].ToString();
        numbers += others[i].ToString();
    }
    Console.WriteLine($"{numbers}");
    //Array.Sort(digits);
    //string match = "";
    //for (int i = 0; i < digits.Length; i++)
    //{
    //    if (i = 1)
    //    {

    //    }
    //}
    //Console.WriteLine(match);

    // Konverterar char till int
    //int[] digitsInts = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));

    // ReadLine som styr while-loopens bool.
    Console.Write("\nTryck 0 för att avsluta eller valfritt tecken för att fortsätta: ");
    string close = Console.ReadLine();
    Console.WriteLine();
    if (close == "0")
    {
        closeProgram = true;
    }
}


////Användarens textsträng
//Console.Write("Skriv in valfri sekvens: ");
//string userInput = Console.ReadLine();
//string dubblet = "Finns inga dubbletter i strängen.";
//int digitOne = 0;
//int digitTwo = 0;

//for (int i = 0; i < userInput.Length; i++)
//{
//    for (int j = 0; j < userInput.Length; j++)
//    {
//        if (char.IsDigit(userInput[i]))
//        {
//            digitOne = userInput[i];
//            if (userInput[i] < userInput[j])
//            {
//                if (digitOne == userInput[j])
//                {
//                    digitTwo = userInput[j];
//                    dubblet = "Hittad!";
//                }
//            }
//        }

//    }
//}
//Console.WriteLine($"{dubblet} Tal 1 {digitOne} Tal 2 {digitTwo}");

//string sequenceOne = userInput.Substring(userInput.IndexOf(digitTwo.ToString(), digitOne));
//Console.WriteLine(sequenceOne);

//// Konverterar anvnändarens sträng till en char array
//char[] userInputToChar = userInput.ToCharArray();

//string firstOcc = "", secondOcc = "";
//string firstPart = "";
//string singleDigit = "";

//for (int i = 0; i < userInput.Length; i++)
//{
//    if (userInput[i] == )
//    {

//    }
//    if (char.IsDigit(userInput[i]))
//    {
//        firstOcc = userInput.Substring(userInput.IndexOf(userInputToChar[i], 0));
//        secondOcc = userInput.Substring(userInput.IndexOf(userInputToChar[i], 1));
//        singleDigit = secondOcc[i].ToString();
//        break;
//    }
//}

//string[] firstOccParts = firstOcc.Split(secondOcc);

//firstPart += firstOccParts[0] + singleDigit;

//Console.WriteLine($"FP: {firstPart}\nSP: {secondOcc}");