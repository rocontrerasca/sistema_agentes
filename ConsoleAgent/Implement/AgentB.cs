using ConsoleAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgent.Implement
{
    public class AgentB : IAgent
    {
        public double GetMedia(List<double> input)
        {
            double sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = sum + (1 / input[i]);
            }

            return input.Count / sum;
        }

        public string GetStaircase(int number)
        {
            string stair = string.Empty;
            for (int i = 0; i < number; i++)
                stair += new String('#', number - i).PadLeft(number, ' ') + Environment.NewLine;
            return stair;
        }

        public void ShowMedia(double number)
        {
            Console.WriteLine("Media armónica: " + number);
        }

        public void ShowStair(string stair)
        {
            Console.WriteLine(stair);
        }
    }
}
