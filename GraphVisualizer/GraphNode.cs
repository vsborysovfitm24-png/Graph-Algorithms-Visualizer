using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualizer
{
    public class GraphNode
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public GraphNode(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
