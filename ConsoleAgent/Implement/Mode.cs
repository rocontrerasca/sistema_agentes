using ConsoleAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgent.Implement
{
    public class Mode : IMode
    {
        // Instance Variables
        private string mode;
        private IAgent agent;
        private List<double> inputs = new List<double>();
        private Dictionary<string, IAgent> agents = new Dictionary<string, IAgent>(){
            {"A", new AgentA()},
            {"B", new AgentB()},
            {"C", new AgentC()},
        };

        // Constructor Declaration of Class
        public Mode(string _mode)
        {
            this.mode = _mode;
            agent = new AgentA();
        }

        // Constructor Declaration of Class
        public Mode()
        {
            mode = String.Empty;
            agent = new AgentA();
        }

        // Property Agent
        public void SetAgent(IAgent _agent)
        {
            agent = _agent;
        }


        public void Execute()
        {
            if (mode.Equals("1"))
                agent.ShowMedia(agent.GetMedia(inputs));
            else
                agent.ShowStair(agent.GetStaircase((int)inputs.FirstOrDefault()));
        }

        public void ReadDataInput()
        {
            if (mode.Equals("2"))
            {
                Console.WriteLine("    Ingrese tamaño escalera    ");
                int.TryParse(Console.ReadLine(), out int totalInputs);
                if (totalInputs <= 0)
                    ReadDataInput();
                else
                {
                    inputs.Add(totalInputs);
                }
            }
            else
            {
                Console.WriteLine("    Ingrese cantidad datos    ");
                int.TryParse(Console.ReadLine(), out int totalInputs);
                if (totalInputs == 0)
                    ReadDataInput();
                else
                {
                    while (inputs.Count < totalInputs)
                    {
                        Console.WriteLine(String.Format("    Ingrese posición {0}    ", inputs.Count + 1));
                        double inputPos;
                        var result = double.TryParse(Console.ReadLine(), out inputPos);
                        if (result)
                            inputs.Add(inputPos);
                    }
                }
            }
        }

        public void ReadAgent()
        {
            Console.WriteLine("    Seleccione Agente        ");
            Console.WriteLine("    AGENTE A                 ");
            Console.WriteLine("    AGENTE B                 ");
            Console.WriteLine("    AGENTE C                 ");

            string? agentInput = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrEmpty(agentInput) || !agents.ContainsKey(agentInput))
                ReadAgent();
            else
                agent = agents[agentInput];
        }
    }
}
