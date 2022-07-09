using System.Collections.Generic;

namespace ImplementingInterface.Models
{
    public class Header
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Root
    {
        public List<Variable> variables { get; set; }
    }

    public class Value
    {
        public List<Header> headers { get; set; }
        public List<List<string>> rows { get; set; }
    }

    public class Variable
    {
        public string name { get; set; }
        public string type { get; set; }
        public Value value { get; set; }
    }

}
