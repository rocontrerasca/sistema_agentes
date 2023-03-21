using ConsoleAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgent.Implement
{
    public class AgentA : IAgent
    {
        public double GetMedia(List<double> input)
        {
            return input.Average();
        }

        public string GetStaircase(int number)
        {
            string stair = string.Empty;
            for (int i = 0; i < number; i++)
                stair += new String('#', i + 1).PadLeft(number, ' ') + Environment.NewLine;
            return stair;
        }

        public void ShowMedia(double number)
        {
            Console.WriteLine("Media aritmética ó promedio: " + number);
        }

        public void ShowStair(string stair)
        {
            Console.WriteLine(stair);
        }
    }
}
