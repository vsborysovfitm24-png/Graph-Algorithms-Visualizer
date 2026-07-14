using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraphVisualizer
{
    public partial class MainForm : Form
    {
        private Graph graph = new Graph();
        private BFSAlgorithm bfsAlgorithm = new BFSAlgorithm();
        private List<GraphNode> nodes = new List<GraphNode>();
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            pnlGraph.Paint += pnlGraph_Paint;
        }

        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            string vertexName = txtVertex.Text.Trim();

            if (string.IsNullOrWhiteSpace(vertexName))
            {
                MessageBox.Show(
                    "Введіть назву вершини.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool added = graph.AddVertex(vertexName);

            if (!added)
            {
                MessageBox.Show(
                    "Така вершина вже існує.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Point point = GetRandomPoint();

            nodes.Add(new GraphNode(vertexName, point.X, point.Y));

            MessageBox.Show(
                $"Вершину {vertexName} успішно додано.",
                "Додавання вершини",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtVertex.Clear();

            pnlGraph.Invalidate();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string from = txtEdgeFrom.Text.Trim();
            string to = txtEdgeTo.Text.Trim();

            if (string.IsNullOrWhiteSpace(from) ||
                string.IsNullOrWhiteSpace(to))
            {
                MessageBox.Show(
                    "Введіть дві вершини для створення ребра.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            bool added = graph.AddEdge(from, to);


            if (!added)
            {
                MessageBox.Show(
                    "Не вдалося додати ребро. Перевірте існування вершин.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            MessageBox.Show(
                $"Ребро {from} - {to} успішно створено.",
                "Додавання ребра",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            txtEdgeFrom.Clear();
            txtEdgeTo.Clear();

            pnlGraph.Invalidate();
        }

        private void btnRunBFS_Click(object sender, EventArgs e)
        {
            string startVertex = txtStartVertex.Text.Trim();

            if (string.IsNullOrWhiteSpace(startVertex))
            {
                MessageBox.Show("Введіть стартову вершину для BFS.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!graph.ContainsVertex(startVertex))
            {
                MessageBox.Show("Такої стартової вершини не існує.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> result = bfsAlgorithm.RunBFS(graph, startVertex);

            lstResults.Items.Clear();

            if (result.Count == 0)
            {
                lstResults.Items.Add("Обхід не виконано.");
                return;
            }

            lstResults.Items.Add("Порядок обходу BFS:");
            lstResults.Items.Add(string.Join(" -> ", result));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graph.Clear();
            nodes.Clear();

            txtVertex.Clear();
            txtEdgeFrom.Clear();
            txtEdgeTo.Clear();
            txtStartVertex.Clear();
            lstResults.Items.Clear();

            pnlGraph.Invalidate();
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen edgePen = new Pen(Color.Gray, 2);
            Brush nodeBrush = Brushes.LightBlue;
            Pen nodePen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10, FontStyle.Bold);

            HashSet<string> drawnEdges = new HashSet<string>();

            foreach (GraphNode node in nodes)
            {
                foreach (string neighborName in graph.GetNeighbors(node.Name))
                {
                    string edgeKey1 = node.Name + "-" + neighborName;
                    string edgeKey2 = neighborName + "-" + node.Name;

                    if (drawnEdges.Contains(edgeKey1) || drawnEdges.Contains(edgeKey2))
                        continue;

                    GraphNode neighbor = nodes.FirstOrDefault(n => n.Name == neighborName);

                    if (neighbor != null)
                    {
                        g.DrawLine(edgePen, node.X, node.Y, neighbor.X, neighbor.Y);
                        drawnEdges.Add(edgeKey1);
                    }
                }
            }

            foreach (GraphNode node in nodes)
            {
                int radius = 35;

                g.FillEllipse(nodeBrush, node.X - radius / 2, node.Y - radius / 2, radius, radius);
                g.DrawEllipse(nodePen, node.X - radius / 2, node.Y - radius / 2, radius, radius);

                SizeF textSize = g.MeasureString(node.Name, font);

                g.DrawString(
                    node.Name,
                    font,
                    Brushes.Black,
                    node.X - textSize.Width / 2,
                    node.Y - textSize.Height / 2
                );
            }
        }

        private Point GetRandomPoint()
        {
            int margin = 50;

            int x = random.Next(margin, pnlGraph.Width - margin);
            int y = random.Next(margin, pnlGraph.Height - margin);

            return new Point(x, y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnGraphInfo_Click(object sender, EventArgs e)
        {
            string message =
                "Інформація про граф\n\n" +
                "Кількість вершин: " +
                graph.GetVertexCount() +
                "\n" +
                "Кількість ребер: " +
                graph.GetEdgeCount() +
                "\n\n" +
                "Список суміжності:\n\n" +
                graph.GetGraphInfo();


            MessageBox.Show(
                message,
                "Граф",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}