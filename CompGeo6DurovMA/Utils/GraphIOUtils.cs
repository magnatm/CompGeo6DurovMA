using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompGeo6DurovMA.Logic;

namespace CompGeo6DurovMA.Utils
{
    public class GraphIOUtils
    {
        public static void SaveGraph(Graph graph, string saveFileName)
        {
            StreamWriter writer = new StreamWriter(saveFileName, true, Encoding.Default);
            for (int i = 0; i < graph.NodesList.Count; i++)
            {
                writer.WriteLine(graph.NodesList[i].Name);
                writer.WriteLine(graph.NodesList[i].X0);
                writer.WriteLine(graph.NodesList[i].Y0);
                writer.WriteLine(graph.NodesList[i].BorderColor.ToArgb());
                writer.WriteLine(graph.NodesList[i].FillColor.ToArgb());
                writer.WriteLine(graph.NodesList[i].FontColor.ToArgb());
                if (graph.NodesList[i].IsEllipse)
                {
                    writer.WriteLine("ELLIPSE");
                }
                else
                {
                    writer.WriteLine("SQUARE");
                }
            }
            writer.WriteLine("NODESDONE");
            writer.WriteLine("");

            for (int i = 0; i < graph.EdgesList.Count; i++)
            {
                writer.WriteLine(graph.EdgesList[i].EdgeColor.ToArgb());
                writer.WriteLine(graph.EdgesList[i].ArrowColor.ToArgb());
                writer.WriteLine(graph.EdgesList[i].RightNode.X0);
                writer.WriteLine(graph.EdgesList[i].RightNode.Y0);
                writer.WriteLine(graph.EdgesList[i].LeftNode.X0);
                writer.WriteLine(graph.EdgesList[i].LeftNode.Y0);
            }
            writer.WriteLine("EDGESDONE");

            writer.Close();
        }

        public static Graph LoadGraph(string loadFileName)
        {
            Graph graphRGraph = new Graph();
            StreamReader reader = new StreamReader(loadFileName, Encoding.Default);
            string line = String.Empty;
            while ((line = reader.ReadLine()) != "NODESDONE")
            {
                NodeGraph node = new NodeGraph();
                node.Edges = new List<EdgeGraph>();
                node.Name = line;
                node.X0 = Convert.ToInt32(reader.ReadLine());
                node.Y0 = Convert.ToInt32(reader.ReadLine());
                node.BorderColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                node.FillColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                node.FontColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                if ((line = reader.ReadLine()) == "SQUARE")
                {
                    node.IsEllipse = false;
                }
                else
                {
                    node.IsEllipse = true;
                }
                graphRGraph.NodesList.Add(node);
            }

            while ((line = reader.ReadLine()) != "EDGESDONE")
            {
                if (line != "")
                {
                    EdgeGraph edge = new EdgeGraph();
                    edge.EdgeColor = Color.FromArgb(Convert.ToInt32(line));
                    edge.ArrowColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                    int xTemp = Convert.ToInt32(reader.ReadLine());
                    int yTemp = Convert.ToInt32(reader.ReadLine());
                    NodeGraph tmp = new NodeGraph();
                    tmp = graphRGraph.FindByXY(xTemp, yTemp);
                    edge.RightNode = tmp;
                    tmp.Edges.Add(edge);

                    xTemp = Convert.ToInt32(reader.ReadLine());
                    yTemp = Convert.ToInt32(reader.ReadLine());
                    tmp = graphRGraph.FindByXY(xTemp, yTemp);
                    edge.LeftNode = tmp;
                    tmp.Edges.Add(edge);

                    graphRGraph.EdgesList.Add(edge);
                }
            }

            reader.Close();
            return graphRGraph;
        }
    }
}
