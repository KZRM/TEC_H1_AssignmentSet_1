namespace OpgaveSæt
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool softwareActive = true;
            while (softwareActive)
            {
                int assignment = 0;
                int page = 0;
                Console.WriteLine(
                    "Vælg opgave:\n" +
                    "1. 'Hej Verden'\n" +
                    "2. 'Simpel Variabel'\n" +
                    "3. 'Matematiske operationer'\n" +
                    "4. 'If-Else Tjek alder'\n" +
                    "5. 'Konverter temperatur'\n" +
                    "6. 'lommeregner'\n" +
                    "7. 'Velkomst besked metode'\n" +
                    "8. 'For løkke'\n" +
                    "9. 'Frugt array'\n" +
                    "10. '2D Array'\n" +
                    "11. 'Konstanter'\n" +
                    "12. 'Email validering'\n" +
                    "13. 'Fixe sænkeslagskib' --- (Denne gør ikke noget)'\n" +
                    "14. 'kommenter koden --- (Denne gør ikke noget)'\n" +
                    "15. 'Tal rækkefølge'\n" +
                    "16. 'Regn BMI'\n" +
                    "17. 'string manipulation'\n" +
                    "18. 'Talgenkendelse i loop'\n" +
                    "19. 'Forklar om Versionsstyring'\n" +
                    "20. 'Login test'\n"
                    );

                assignment = InputAsValidInt();

                if (page == 0)
                {
                    switch (assignment)
                    {
                        default:
                        case 1: /// Opgave 1 - Hej Verden:
                            Console.Clear();
                            Console.WriteLine("Hello, World!");
                            break;

                        case 2: /// Opgave 2 - Simpel Variabel:
                            Console.Clear();
                            string thing = "i'm a thing!";
                            Console.WriteLine(thing);
                            break;

                        case 3: /// Opgave 3 - Matematiske operationer:
                            Console.Clear();
                            MathematicalFunctions();
                            break;

                        case 4: /// Opgave 4 - If-Else Tjek alder:
                            Console.Clear();
                            CheckAge();
                            break;

                        case 5: /// Opgave 5 - Konverter temperatur:
                            Console.Clear();
                            FahrenHeitToCelsius();
                            break;

                        case 6: /// Opgave 6 - lommeregner:
                            Console.Clear();
                            Calculator();
                            break;

                        case 7: /// Opgave 7 - Velkomst besked metode:
                            Console.Clear();
                            PrintWelcomMessage();
                            break;

                        case 8: /// Opgave 8 - For løkke:
                            Console.Clear();
                            for (int i = 1; i <= 10; i++) Console.Write(i + " ");
                            break;

                        case 9: /// Opgave 9 - Frugt array:
                            Console.Clear();
                            FruitPrinter();
                            break;

                        case 10: /// Opgave 10 - 2D Array:
                            Console.Clear();
                            NumberPrinter();
                            break;

                        case 11: /// Opgave 11 - Konstanter:
                            Console.Clear();
                            Constants();
                            break;

                        case 12: /// Opgave 12 - Email validering:
                            Console.Clear();
                            EmailValidation();
                            break;

                        case 13: /// Opgave 13
                                 /// ???????????????????????????????????
                            Console.Clear();
                            break;

                        case 14: /// Opgave 14 - kommenter koden 
                                 /// Der er løbende blevet lavet kommentarer... Inklusiv denne :).
                            Console.Clear();
                            break;

                        case 15: /// Opgave 15 - Tal rækkefølge
                            Console.Clear();
                            SortNumbers();
                            break;

                        case 16: /// Opgave 16 - Regn BMI:
                            Console.Clear();
                            CalcBMI();
                            break;

                        case 17: /// Opgave 17 - string manipulation: 
                            Console.Clear();
                            StringManipulation();
                            break;

                        case 18: /// Opgave 18 - Talgenkendelse med Løkke
                            Console.Clear();
                            NumberRecognition();
                            break;

                        case 19: /// Opgave 19 - Forklar om Versionsstyring.

                                 /// Versions-styring: (Source control) er en måde at sørge for at et projekt er accesible og non-destructive. 
                                 /// "Non-destructive" i form af at man kan lave eksperimentielle afgreninger af projektet, og all beslutninger kan rulles tilbage.
                                 /// "Accesible" som i at det sørge for at mange folk kan have adgang til det samme projekt på en gang, 
                                 /// i stedet for at skulle vente på hver part er færdig med at arbejde på deres andel.
                                 /// Git er et populært versionsstyrings værktøj. Udfra Git har man bygget populære værktøjer som Github og SourceTree.
                            Console.Clear();
                            WriteLongComment();
                            break;

                        case 20: /// Opgave 20 - Basis Login System.
                            Console.Clear();
                            LoginTest();
                            break;

                        /// RUTINEREDE OPGAVER:

                        case 21: /// Avanceret lommeregner

                            Console.WriteLine("Write first number:");
                            float numA = InputAsValidFloat();
                            Console.WriteLine("Write second number:");
                            float numB = InputAsValidFloat();
                            Console.WriteLine("Write operator type:");
                            char inputOperator = IsValidOperatorSymbolExtended();
                            switch (inputOperator)
                            {
                                case '-':
                                    Console.WriteLine($"{numA} - {numB} = {numA - numB}");
                                    break;
                                case '+':
                                    Console.WriteLine($"{numA} + {numB} = {numA + numB}");
                                    break;
                                case '/':
                                    Console.WriteLine($"{numA} / {numB} = {numA / numB}");
                                    break;
                                case '*':
                                    Console.WriteLine($"{numA} * {numB} = {numA * numB}");
                                    break;
                                case '%':
                                    Console.WriteLine($"{numA} % {numB} = {numA % numB}");
                                    break;
                                case '^':
                                    Console.WriteLine($"{numA} ^ {numB} = {Math.Pow(numA, numB)}");
                                    break;
                            }
                            break;

                        case 22:
                            List<int> randomNums = new List<int>();
                            for (int i = 0; i < 10; i++)
                                randomNums.Add(new Random().Next(0, 101));
                            foreach (int num in randomNums)
                                Console.Write(num + " ");

                            break;

                        case 23: /// Palindrom checker
                            Console.WriteLine("Skriv orf og tjek om det er et palindrom:");
                            string inputString = Console.ReadLine().ToLower();
                            string reverseString = new string(inputString.Reverse().ToArray());
                            Console.WriteLine($"{inputString} baglæns er {reverseString}");
                            string resultLine = inputString == reverseString ? "Som er et palindrom!" : "Så det er IKKE et palindrom";
                            Console.WriteLine(resultLine);
                            break;

                        case 24: /// Valuta konvertering
                            const float dollarToKRRate = 7.21f;
                            Console.WriteLine("Skriv et beløb i dollar:");
                            float inputNum = InputAsValidFloat();
                            Console.WriteLine($"{inputNum}Kr, er {inputNum * dollarToKRRate} dollars");
                            break;

                        case 25:
                            int secretNum = new Random().Next(0, 101);
                            Console.WriteLine("Gæt mit hemmelige nummer imellem 1 og 100");
                            inputNum = InputAsValidInt();
                            while (secretNum != inputNum)
                            {
                                Console.WriteLine("Det er forkert, prøv igen:");
                                inputNum = InputAsValidInt();
                            }
                            Console.WriteLine("Korrekt, godt gættet!");
                            break;

                        case 26:
                            string[] names = { "Peter", "Sørgen", "Kasper",
                                "Lise", "Lotte", "Bo",
                                "Sebastian", "Lisbet", "Lars", "Jørgen" };

                            int currentPage = 0;
                            int pageSize = 3;

                            /// Sørger for at max sider er baseret på arrayet længde / størrelse på side
                            int totalPages = (int)Math.Ceiling((float)names.Length / pageSize);


                            bool active = true;

                            while (active)
                            {
                                Console.Clear();
                                Console.WriteLine($"PAGE: {currentPage + 1}/{totalPages}\n");

                                int startIndex = currentPage * pageSize;

                                /// index i for loopet skal aldrig overstige størrelsen på names arrayet:
                                int endIndex = Math.Clamp(startIndex + pageSize, 0, names.Length);

                                for (int i = startIndex; i < endIndex; i++)
                                    Console.WriteLine(names[i]);

                                /// Logic baseret på key input:
                                ConsoleKey inputKey = Console.ReadKey(true).Key;

                                if (inputKey == ConsoleKey.RightArrow || inputKey == ConsoleKey.D)
                                    currentPage = Math.Clamp(currentPage + 1, 0, totalPages - 1);

                                else if (inputKey == ConsoleKey.LeftArrow || inputKey == ConsoleKey.A)
                                    currentPage = Math.Clamp(currentPage - 1, 0, totalPages - 1);

                                else if (inputKey == ConsoleKey.Spacebar)
                                    active = false;

                            }




                            break;

                        case 27:
                            /// Fejl meddelelser:

                            break;
                        case 28:
                            break;
                        case 29:
                            break;
                        case 30:
                            break;
                        case 31:
                            break;
                        case 32:
                            break;
                        case 33:
                            break;
                        case 34:
                            break;
                        case 35:
                            break;
                        case 36:
                            break;
                        case 37:
                            break;
                        case 38:
                            break;
                        case 39:
                            break;
                        case 40:
                            break;

                    }
                }

                Console.ReadKey(true);
                Console.Clear();
            }

            static void MathematicalFunctions()
            {
                Console.WriteLine("Write first number:");
                float numA = InputAsValidFloat();
                Console.WriteLine("Write second number:");
                float numB = InputAsValidFloat();
                Console.WriteLine("Some calculations: \n" +
                    $"Addition: {numA} + {numB} = {numA + numB}\n" +
                    $"Subtraction: {numA} - {numB} = {numA - numB}\n" +
                    $"Multiplication: {numA} * {numB} = {numA * numB}\n" +
                    $"Division: {numA} / {numB} = {numA / numB}\n");
            }

            static void CheckAge()
            {
                Console.WriteLine("Write your age:");
                float age = InputAsValidFloat();
                if (age > 17)
                    Console.WriteLine("You are of legal age");
                else
                    Console.WriteLine("You are a child.");
            }

            static void FahrenHeitToCelsius()
            {
                Console.WriteLine("Please write a temperature in Fahrenheit:");
                float tempFahrenheit = InputAsValidFloat();
                float Celsius = ((5f / 9f) * (tempFahrenheit - 32f));
                Console.WriteLine(tempFahrenheit + " fahrenheit is the same as " + Celsius + "celsius");
            }

            static void Calculator()
            {
                Console.WriteLine("Write first number:");
                float numA = InputAsValidFloat();
                Console.WriteLine("Write second number:");
                float numB = InputAsValidFloat();
                Console.WriteLine("Write operator type:");
                char inputOperator = IsValidOperatorSymbol();
                switch (inputOperator)
                {
                    case '-':
                        Console.WriteLine($"{numA} - {numB} = {numA - numB}");
                        break;
                    case '+':
                        Console.WriteLine($"{numA} + {numB} = {numA + numB}");
                        break;
                    case '/':
                        Console.WriteLine($"{numA} / {numB} = {numA / numB}");
                        break;
                    case '*':
                        Console.WriteLine($"{numA} * {numB} = {numA * numB}");
                        break;
                }
            }

            static void Constants()
            {
                const float quarterOffDiscount = 0.25f;
                Console.WriteLine("Write first number:");
                float numA = InputAsValidFloat();
                Console.WriteLine("Original price: " + numA + " with our GREAT discount: " + (numA * (1 - quarterOffDiscount)) + "!");
            }

            static void EmailValidation()
            {
                string userInput; bool validInput = false;
                Console.WriteLine("Please write a valid email: ");
                do
                {
                    userInput = Console.ReadLine();
                    if (userInput.Contains('@') && userInput.Contains('.'))
                        validInput = true;
                    else
                        Console.WriteLine("Not a valid mail, needs a '@' and a '.', try again...");
                } while (!validInput);
            }

            static void SortNumbers()
            {
                Console.WriteLine("Skriv tre tal:");
                float num1 = InputAsValidFloat();
                float num2 = InputAsValidFloat();
                float num3 = InputAsValidFloat();
                float[] numbers = new float[] { num1, num2, num3 };
                numbers.OrderBy(x => x);
            }

            static void CalcBMI()
            {
                Console.WriteLine("Skriv højde i meter mål med komma. Eks. '1,85'");
                float m_height = InputAsValidFloat();
                Console.WriteLine("Skriv vægt i kg. Eks: '75kg'");
                float kg_weight = InputAsValidFloat();
                float BMI = kg_weight / MathF.Pow(m_height, 2f);
                Console.WriteLine($"din BMI er {BMI}");
            }

            static void StringManipulation()
            {
                /// (har jeg gjordt i de fleste opgaver)
                float num1 = InputAsValidFloat();
                Console.WriteLine($"{num1} er et tal...");
            }

            static void NumberRecognition()
            {
                float correctNumber = new Random().Next(1, 11);
                float guessedNumber = -1;
                Console.WriteLine("Please guess my number... It is between 1 and 10");
                while (correctNumber != guessedNumber)
                {
                    guessedNumber = InputAsValidFloat();
                    if (correctNumber != guessedNumber) Console.WriteLine($"{guessedNumber} is a wrong number... try again");
                }
                Console.WriteLine($"Correct my number was {correctNumber}");
            }

            static void WriteLongComment()
            {
                // og som string i consollen:
                Console.WriteLine(
                                        "Versions-styring: (Source control) er en måde at sørge for at et projekt er accesible og non-destructive.\n" +
                                    "\"Non-destructive\" i form af at man kan lave eksperimentielle afgreninger af projektet, og all beslutninger kan rulles tilbage.\n" +
                                    "\"Accesible\" som i at det sørge for at mange folk kan have adgang til det samme projekt på en gang,\n" +
                                    "i stedet for at skulle vente på hver part er færdig med at arbejde på deres andel.\n" +
                                    "Git er et populært versionsstyrings værktøj. Udfra Git har man bygget populære værktøjer som Github og SourceTree."
                                    );
            }

            static void LoginTest()
            {
                /// pre-definerede login oplysninger:
                string username = "peter1988", password = "peter1234";
                string inputUsername = "", inputPassword = "";
                bool correctPassword = false;
                while (!correctPassword)
                {
                    inputUsername = ""; inputPassword = "";
                    Console.WriteLine("Please write your username: ");
                    inputUsername = Console.ReadLine();

                    Console.WriteLine("Please write your password: ");
                    inputPassword = GetInputPasswordEncrypted(inputPassword);
                    if (inputUsername == username && inputPassword == password)
                    {
                        correctPassword = true;
                        Console.WriteLine("Correct password!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect password!");
                        Console.WriteLine(inputPassword + " " + inputUsername);
                    }
                }


            }

            static void FruitPrinter()
            {
                string[] fruits = { "Æble", "Pære", "Banan", "Citron" };
                foreach (string fruit in fruits) Console.WriteLine(fruit + " ");
            }

            static void NumberPrinter()
            {
                // printer '5' da den går 0>1>2 hen og tager 0 index.
                int[,] tabel = { { 1, 8 }, { 2, 7 }, { 5, 10 } };
                Console.WriteLine(tabel[2, 0]);
            }
        }

        private static string GetInputPasswordEncrypted(string inputPassword)
        {
            bool writingPassword = true;
            inputPassword = "";

            while (writingPassword)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    writingPassword = false;
                    Console.WriteLine();
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (inputPassword.Length > 0)
                    {
                        inputPassword = inputPassword.Remove(inputPassword.Length - 1);
                        Console.Write("\b \b"); // BackSpace!
                        /// Første \b rykker cursoren en tilbage, mellem rummet erstatter symbolet der, 
                        /// andet b rykker curser tilbage igen så der ikke er huller.
                    }
                }
                else
                {
                    Console.Write("*");
                    inputPassword += key.KeyChar;
                }
            }
            return inputPassword;
        }


        private static void PrintWelcomMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome!");
            Console.ResetColor();
        }

        private static char IsValidOperatorSymbol()
        {
            /// Opgave 6 - Lommeregner:
            char inputChar;
            bool validInput = false;
            do
            {
                inputChar = Console.ReadKey(true).KeyChar;
                if (
                    inputChar == '-' ||
                    inputChar == '+' ||
                    inputChar == '*' ||
                    inputChar == '/'
                    )
                { validInput = true; }
                else
                {
                    Console.WriteLine("Not a vlid key, use +, *, / or -");
                }
            } while (!validInput);
            return inputChar;
        }

        private static char IsValidOperatorSymbolExtended()
        {
            /// Opgave 6 - Lommeregner:
            char inputChar;
            bool validInput = false;
            do
            {
                inputChar = Console.ReadKey(true).KeyChar;
                if (
                    inputChar == '-' ||
                    inputChar == '+' ||
                    inputChar == '*' ||
                    inputChar == '/' ||
                    inputChar == '%' ||
                    inputChar == '^'
                    )
                { validInput = true; }
                else
                {
                    Console.WriteLine("Not a vlid key, use +, *, / or -");
                }
            } while (!validInput);
            return inputChar;
        }

        private static float InputAsValidFloat()
        {
            float numA;
            while (!float.TryParse(Console.ReadLine(), out numA))
            {
                Console.WriteLine("Not a valid number! try again.");
            }

            return numA;
        }

        private static int InputAsValidInt()
        {
            int numA;
            while (!int.TryParse(Console.ReadLine(), out numA))
            {
                Console.WriteLine("Not a valid integer! try again.");
            }

            return numA;
        }


    }
}
