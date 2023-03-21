using ConsoleAgent.Implement;
using ConsoleAgent.Interfaces;

namespace TestProject
{
    public class UnitTestAgentA
    {
        [Fact]
        public void TestMedia()
        {
            IAgent agent = new AgentA();

            var data = new List<List<double>>() { new List<double> { 1, 2, 3 }, new List<double> { 10, 25, 13, 5.7 },
                new List<double> { 1, 5, 66, 3.7, 2.1 } };

            foreach (var item in data)
            {
                Assert.Equal(item.Average(), agent.GetMedia(item));
            }
        }

        [Fact]
        public void TestStaircase()
        {
            IAgent agent = new AgentA();

            Dictionary<int, string> data = new Dictionary<int, string>(){
            {4, "   #\r\n  ##\r\n ###\r\n####"},
            {3, "  #\r\n ##\r\n###"},
            {5, "    #\r\n   ##\r\n  ###\r\n ####\r\n#####"}
            };

            foreach (var item in data)
            {
                Assert.Equal(item.Value, agent.GetStaircase(item.Key));
            }
        }
    }
}