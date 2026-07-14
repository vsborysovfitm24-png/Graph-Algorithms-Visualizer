using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualizer
{
    public class BFSAlgorithm
    {
        public List<string> RunBFS(Graph graph, string startVertex)
        {
            List<string> result = new List<string>();

            if (graph == null || string.IsNullOrWhiteSpace(startVertex))
                return result;

            startVertex = startVertex.Trim();

            if (!graph.ContainsVertex(startVertex))
                return result;

            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();

            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                result.Add(current);

                foreach (string neighbor in graph.GetNeighbors(current))
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }
}
