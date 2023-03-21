using ConsoleAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgent.Implement
{
    public class AgentC : IAgent
    {
        public double GetMedia(List<double> input)
        {
            //Ordenar arreglo
            input.Sort();

            //get the median
            int size = input.Count;
            int mid = size / 2;
            if (size % 2 != 0)
                return input[mid];

            dynamic value1 = input[mid];
            dynamic value2 = input[mid - 1];
            return (value1 + value2) / 2;
        }

        public string GetStaircase(int number)
        {
            string stairUp = string.Empty;
            string stairDown = string.Empty;
            var offset = ((number - 1) * 2) / 2;

            for (int i = 0; i < number; i++)
            {                
                stairUp += new String('#', number + (2 * i)).PadLeft(number + (2 * i) + offset, ' ').PadRight(number + (2 * i) + (offset * 2), ' ') + Environment.NewLine;
                offset -= 1;
            }
            offset = 1;
            for (int i = number - 2; i >= 0; i--)
            {
                stairDown += new String('#', number + (2 * i)).PadLeft(number + (2 * i) + offset, ' ').PadRight(number + (2 * i) + (offset * 2), ' ') + Environment.NewLine;
                offset += 1;
            }
            return stairUp + stairDown;
        }

        public void ShowMedia(double number)
        {
            Console.WriteLine("Mediana: " + number);
        }

        public void ShowStair(string stair)
        {
            Console.WriteLine(stair);
        }
    }
}
