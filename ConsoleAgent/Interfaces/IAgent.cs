using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgent.Interfaces
{
    public interface IAgent
    {
        double GetMedia(List<double> inputs);
        string GetStaircase(int number);

        void ShowMedia(double number);

       void ShowStair(string stair);
    }
}
