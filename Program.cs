using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePrac
{
    delegate void Spins(ref int energy, ref int winningProbability);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a number from 1 to 10.");
            Console.WriteLine("Initially - Energy level: 1, Winning probability: 100");
            Console.WriteLine("Total number of spins: 5");

            int totalEnergy = 1;
            int probability = 100;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter your spin for spin {i + 1}: ");
                int spin = int.Parse(Console.ReadLine());

                Spins sp;
                switch (spin)
                {
                    case 1:
                        sp = (ref int energy, ref int winningProbability) => { energy += 1; winningProbability += 10; };
                        break;
                    case 2:
                        sp = (ref int energy, ref int winningProbability) => { energy += 2; winningProbability += 20; };
                        break;
                    case 3:
                        sp = (ref int energy, ref int winningProbability) => { energy -= 3; winningProbability += 30; };
                        break;
                    case 4:
                        sp = (ref int energy, ref int winningProbability) => { energy -= 4; winningProbability += 50; };
                        break;
                    case 5:
                        sp = (ref int energy, ref int winningProbability) => { energy += 3; winningProbability += 20; };
                        break;
                    case 6:
                        sp = (ref int energy, ref int winningProbability) => { energy += 3; winningProbability +=60; };
                        break;
                    case 7:
                        sp = (ref int energy, ref int winningProbability) => { energy -= 3; winningProbability += 10; };
                        break;
                    case 8:
                        sp = (ref int energy, ref int winningProbability) => { energy += 6; winningProbability += 90; };
                        break;
                    case 9:
                        sp = (ref int energy, ref int winningProbability) => { energy -= 1; winningProbability += 30; };
                        break;
                    case 10:
                        sp = (ref int energy, ref int winningProbability) => { energy -= 3; winningProbability += 30; };
                        break;
                    default:
                        Console.WriteLine("Enter option only from 1-10");
                        i--;
                        continue;
                }

                sp(ref totalEnergy, ref probability);
            }

            string res = GetResult(totalEnergy, probability);
            Console.WriteLine(res);
            Console.ReadKey();

        }

        static string GetResult(int energy, int winningProbability)
        {
            if (energy > 4 && winningProbability > 50)
                return "You are the winner";
            else if (energy > 1 && winningProbability > 50)
                return "You are the runnerup";
            else
                return "You lost";
        }

        
    }

}
