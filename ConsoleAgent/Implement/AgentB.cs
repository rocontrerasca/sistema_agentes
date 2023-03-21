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
            List<string> stair = new List<string>();
            for (int i = 0; i < number; i++)
                stair.Add(new string('#', number - i).PadLeft(number, ' '));
            return string.Join(Environment.NewLine, stair);
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
