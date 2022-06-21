using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3XUnit
{
    public class Application
    {
        public List<string> CalcResults { get; set; }
        public Application()
        {
            CalcResults = new List<string>();
        }
        public void RunMenu()
        {

            bool correctAnswer = false;
            while (!correctAnswer)
            {
                Console.WriteLine("Vad vill du göra?" +
                    "\n1. Räkna med addition" +
                    "\n2. Räkna med subtraktion" +
                    "\n3. Räkna med division" +
                    "\n4. Räkna med multiplikation" +
                    "\n5. Se alla gjorde uträkningar" +
                    "\n6. Avsluta programmet\n");

                string answer = Console.ReadLine();

                List<double?> numbers = new List<double?>();
                Calculator calc = new Calculator();
                string result = "";

                switch (answer)
                {            
                    case "1":
                        Console.Clear();
                        numbers = GetNumbers();
                        result = GetResultString(calc.Addition((double)numbers[0], (double)numbers[1]), "adderat", (double)numbers[0], (double)numbers[1]);
                        Console.WriteLine(result);
                        CalcResults.Add(result);
                        ClickToContinue();
                        break;
                    case "2":
                        Console.Clear();
                        numbers = GetNumbers();
                        result = GetResultString(calc.Subtraction((double)numbers[0], (double)numbers[1]), "subtraherat", (double)numbers[0], (double)numbers[1]);
                        Console.WriteLine(result);
                        CalcResults.Add(result);
                        ClickToContinue();
                        break;
                    case "3":
                        Console.Clear();
                        numbers = GetNumbers();
                        result = GetResultString(calc.Division((double)numbers[0], (double)numbers[1]), "dividerat", (double)numbers[0], (double)numbers[1]);
                        Console.WriteLine(result);
                        CalcResults.Add(result);
                        ClickToContinue();
                        break;
                    case "4":
                        Console.Clear();
                        numbers = GetNumbers();
                        result = GetResultString(calc.Muliplication((double)numbers[0], (double)numbers[1]), "multiplicerat", (double)numbers[0], (double)numbers[1]);
                        Console.WriteLine(result);
                        CalcResults.Add(result);
                        ClickToContinue();
                        break;
                    case "5":
                        Console.Clear(); 
                        Console.WriteLine("\n-----Alla uträkningar-------");
                        foreach (var item in CalcResults)
                        {
                            Console.WriteLine(item);
                        }
                        ClickToContinue();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Testa igen.");
                        break;
                }
            }

        }



        public double? ValidateNumber(string nr)
        {
            if (double.TryParse(nr, out double validNumber))
            {
                return validNumber;
            }
            else return null;
        }

        public List<double?> GetNumbers(string input1="", string input2="")
        {
            List<double?> numbers = new List<double?>();
            bool validNumber1 = false;
            while (!validNumber1)
            {
                if (input1 == "")
                {
                    Console.WriteLine("Mata in nummer 1.");
                    double? nr1 = ValidateNumber(Console.ReadLine());

                    if (nr1 != null) {
                        numbers.Add(nr1);
                        validNumber1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Talet var inte giltigt. Testa igen.\n");
                    }

                }
                else
                {
                    numbers.Add(ValidateNumber(input1));
                    validNumber1 = true;
                }
            }

            bool validNumber2 = false;
            while (!validNumber2)
            {
                if (input1 == "")
                {
                    Console.WriteLine("Mata in nummer 2.");
                    double? nr2 = ValidateNumber(Console.ReadLine());

                    if (nr2 != null)
                    {
                        numbers.Add(nr2);
                        validNumber2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Talet var inte giltigt. Testa igen.\n");
                    }
                }
                else
                {
                    numbers.Add(ValidateNumber(input2));
                    validNumber2 = true;
                }
            }

            return numbers;
        }

        public string GetResultString(double result, string method, double nr1, double nr2)
        {
            return $"\nRESULTAT\n{nr1} {method} med {nr2} är lika med {result}.\n";
        }
        public void ClickToContinue()
        {
            Console.WriteLine("\nKlicka på valfri knapp för att komma vidare.");
            Console.ReadKey();
            Console.Clear();        
        }
    }
}
