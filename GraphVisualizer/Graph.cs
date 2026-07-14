using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualizer
{
    public class Graph
    {
        private Dictionary<string, List<string>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<string, List<string>>();
        }

        public bool AddVertex(string vertex)
        {
            if (string.IsNullOrWhiteSpace(vertex))
                return false;

            vertex = vertex.Trim();

            if (adjacencyList.ContainsKey(vertex))
                return false;

            adjacencyList[vertex] = new List<string>();
            return true;
        }

        public bool AddEdge(string from, string to)
        {
            if (adjacencyList[from].Contains(to))
                return false;

            if (string.IsNullOrWhiteSpace(from) || string.IsNullOrWhiteSpace(to))
                return false;

            from = from.Trim();
            to = to.Trim();

            if (!adjacencyList.ContainsKey(from) || !adjacencyList.ContainsKey(to))
                return false;

            if (from == to)
                return false;

            if (!adjacencyList[from].Contains(to))
                adjacencyList[from].Add(to);

            if (!adjacencyList[to].Contains(from))
                adjacencyList[to].Add(from);

            return true;
        }

        public bool ContainsVertex(string vertex)
        {
            if (string.IsNullOrWhiteSpace(vertex))
                return false;

            return adjacencyList.ContainsKey(vertex.Trim());
        }

        public List<string> GetNeighbors(string vertex)
        {
            vertex = vertex.Trim();

            if (!adjacencyList.ContainsKey(vertex))
                return new List<string>();

            return adjacencyList[vertex];
        }

        public List<string> GetAllVertices()
        {
            return adjacencyList.Keys.ToList();
        }

        public void Clear()
        {
            adjacencyList.Clear();
        }
        public int GetVertexCount()
        {
            return adjacencyList.Count;
        }


        public int GetEdgeCount()
        {
            int count = 0;

            foreach (var vertex in adjacencyList)
            {
                count += vertex.Value.Count;
            }

            return count / 2;
        }


        public string GetGraphInfo()
        {
            string info = "";

            foreach (var vertex in adjacencyList)
            {
                info += vertex.Key + ": ";

                if (vertex.Value.Count == 0)
                {
                    info += "немає зв'язків";
                }
                else
                {
                    info += string.Join(", ", vertex.Value);
                }

                info += Environment.NewLine;
            }

            return info;
        }
    }
}
