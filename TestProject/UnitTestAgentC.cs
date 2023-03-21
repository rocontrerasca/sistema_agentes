using ConsoleAgent.Implement;
using ConsoleAgent.Interfaces;

namespace TestProject
{
    public class UnitTestAgentC
    {
        [Fact]
        public void TestMedia()
        {
            IAgent agent = new AgentC();

            var data = new List<List<double>>() { new List<double> { 1, 2, 3 }, new List<double> { 10, 25, 13, 5.7 },
                new List<double> { 1, 5, 66, 3.7, 2.1 } };
            var responses = new List<double>() { 2, 11.5, 3.7 };
            for (var i = 0; i < data.Count; i++)
            {
                Assert.Equal(responses[i], agent.GetMedia(data[i]));
            }
        }

        [Fact]
        public void TestStaircase()
        {
            IAgent agent = new AgentC();

            Dictionary<int, string> data = new Dictionary<int, string>(){
            {4, "   ####   \r\n  ######  \r\n ######## \r\n##########\r\n ######## \r\n  ######  \r\n   ####   "},
            {3, "  ###  \r\n ##### \r\n#######\r\n ##### \r\n  ###  "},
            {5, "    #####    \r\n   #######   \r\n  #########  \r\n ########### \r\n#############\r\n ########### \r\n  #########  \r\n   #######   \r\n    #####    "}
            };

            foreach (var item in data)
            {
                Assert.Equal(item.Value, agent.GetStaircase(item.Key));
            }
        }
    }
}