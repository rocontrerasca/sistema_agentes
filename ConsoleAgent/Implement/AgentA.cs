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
            List<string> stair = new List<string>();
            for (int i = 0; i < number; i++)
                stair.Add(new string('#', i + 1).PadLeft(number, ' '));
            return string.Join(Environment.NewLine, stair);
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
