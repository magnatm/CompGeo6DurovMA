using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGeo6DurovMA.Logic
{
    public class Graph
    {
        private List<NodeGraph> NodesList = new List<NodeGraph>();
        private List<EdgeGraph> EdgesList = new List<EdgeGraph>();

        public int GetNodesListCount()
        {
            return NodesList.Count;
        }

        public int GetEdgesListCount()
        {
            return EdgesList.Count;
        }

        public void AddNode(int x, int y, string name)
        {
            if (FindByXY(x, y) == null)
            {
                NodeGraph node = new NodeGraph();
                node.X0 = x;
                node.Y0 = y;
                node.Name = name;
                node.Edges = new List<EdgeGraph>();
                NodesList.Add(node);
            }
        }

        private NodeGraph NodeForMove;

        public void MoveNode(int x, int y)
        {
            if (NodeForMove == null)
            {
                NodeForMove = FindByXY(x, y);
                return;
            }
            else
            {
                NodeForMove.X0 = x;
                NodeForMove.Y0 = y;
                NodeForMove = null;
            }
        }

        private EdgeGraph EdgeGraphAdd;
        public void AddEdge(int x, int y, int weight)
        {
            if (EdgeGraphAdd == null)
            {
                EdgeGraphAdd = new EdgeGraph();
                EdgeGraphAdd.LeftNode = FindByXY(x, y);
                if (EdgeGraphAdd.LeftNode != null)
                {
                    FindByXY(x, y).Edges.Add(EdgeGraphAdd);
                }
                return;
            }
            else
            {
                EdgeGraphAdd.RightNode = FindByXY(x, y);
                if (EdgeGraphAdd.RightNode != null)
                {
                    FindByXY(x, y).Edges.Add(EdgeGraphAdd);
                    EdgeGraphAdd.Weight = weight;
                    EdgesList.Add(EdgeGraphAdd);
                    EdgeGraphAdd = null;
                }
            }
        }

        public void DeleteEdge(int x, int y) //может быть треугольник
        {
            double dist1, dist2, rebro;
            for (int i = 0; i < EdgesList.Count; i++)
            {
                if (EdgesList[i] != null)
                {
                    dist1 = Math.Sqrt(Math.Pow(x - EdgesList[i].LeftNode.X0, 2) +
                                      Math.Pow(y - EdgesList[i].LeftNode.Y0, 2));
                    dist2 = Math.Sqrt(Math.Pow(x - EdgesList[i].RightNode.X0, 2) +
                                      Math.Pow(y - EdgesList[i].RightNode.Y0, 2));
                    rebro = Math.Sqrt(Math.Pow(EdgesList[i].LeftNode.X0 - EdgesList[i].RightNode.X0, 2) +
                                      Math.Pow(EdgesList[i].LeftNode.Y0 - EdgesList[i].RightNode.Y0, 2));
                    if (Math.Abs(dist1 + dist2 - rebro) < 0.1)
                    {
                        for (int k = 0; k < EdgesList[i].LeftNode.Edges.Count; k++)
                        {
                            if (EdgesList[i] == EdgesList[i].LeftNode.Edges[k])
                            {
                                EdgesList[i].LeftNode.Edges[k] = null;
                                EdgesList[i].LeftNode.Edges.RemoveAt(k);
                                k--;
                            }
                        }
                        for (int u = 0; u < EdgesList[i].RightNode.Edges.Count; u++)
                        {
                            if (EdgesList[i] == EdgesList[i].RightNode.Edges[u])
                            {
                                EdgesList[i].RightNode.Edges[u] = null;
                                EdgesList[i].RightNode.Edges.RemoveAt(u);
                                u--;
                            }
                        }

                        EdgesList[i] = null;
                        EdgesList.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (NodeGraph x in NodesList)
            {
                if (x != null)
                {
                    x.IsDrawn = false;
                }
            }
            foreach (NodeGraph x in NodesList)
            {
                if (x != null)
                {
                    Draw(g, x); // передаем один из узлов
                }
            }
        }

        private void Draw(Graphics g, NodeGraph p)
        {
            if (p.IsDrawn) return;
            if (p.Edges != null)
            {
                foreach (EdgeGraph e in p.Edges)
                {
                    if (e != null)
                    {
                        if (p == e.RightNode)
                        {
                            if (e.LeftNode != null)
                            {
                                if (!e.LeftNode.IsDrawn)
                                    DrawEdge(g, p, e.LeftNode, e.Weight, e); 
                            }
                        }

                        if (p == e.LeftNode)
                        {
                            if (e.RightNode != null)
                            {
                                if (!e.RightNode.IsDrawn)
                                    DrawEdge(g, p, e.RightNode, e.Weight, e);
                            }
                        }
                    }
                }
            }

            DrawNode(g, p);
            p.IsDrawn = true;
        }

        private void DrawEdge(Graphics g, NodeGraph p, NodeGraph n, int weight, EdgeGraph edge)////////////////////////////////////////////DORABOTATb
        {
            //if (edge.IsBuilt)
           // {
            //    g.DrawLine(DrawUtils.PenLineSpecial, p.X0, p.Y0, n.X0, n.Y0);
            //    g.DrawString(weight.ToString(), DrawUtils.FontEdge, DrawUtils.BrushEdgesDataSpecial, (p.X0 + n.X0) / 2, (p.Y0 + n.Y0) / 2);
            //}
            //else
            //{
              //g.DrawLine(DrawUtils.PenLine, p.X0, p.Y0, n.X0, n.Y0);
                g.DrawLine(DrawUtils.PenLine,p.X0,p.Y0,p.X0, p.Y0 + (n.Y0 - p.Y0)/2);
                g.DrawLine(DrawUtils.PenLine, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2);
                g.DrawLine(DrawUtils.PenLine, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0);
                g.DrawString(weight.ToString(), DrawUtils.FontEdge, DrawUtils.BrushNodeData, (p.X0 + n.X0) / 2, (p.Y0 + n.Y0) / 2);
            //}

        }

        private void DrawNode(Graphics g, NodeGraph p)
        {
            if (p == NodeForMove)
            {
                g.FillEllipse(DrawUtils.BrushBackHighLight, p.X0 - 20, p.Y0 - 20, 40, 40);
                g.DrawEllipse(DrawUtils.CrimsonPenNode, p.X0 - 20, p.Y0 - 20, 40, 40);
            }
            else
            {
                g.FillEllipse(DrawUtils.BrushBackground, p.X0 - 20, p.Y0 - 20, 40, 40);
                g.DrawEllipse(DrawUtils.PenNode, p.X0 - 20, p.Y0 - 20, 40, 40);
            }

            g.DrawString(p.Name, DrawUtils.FontNode, DrawUtils.BrushNodeData, p.X0 - 12, p.Y0 - 12);
        }

        private NodeGraph FindByXY(int x, int y) // нахождение вершины по координатам через мышку
        {
            foreach (NodeGraph p in NodesList)
            {
                if (p != null)
                {
                    if ((p.X0 - x) * (p.X0 - x) + (p.Y0 - y) * (p.Y0 - y) < 40 * 40) //r - радиус нода
                        return p;
                }
            }
            return null;
        }

        public void DeleteNode(int x, int y)
        {
            if (FindByXY(x, y) != null)
            {
                for (int q = 0; q < NodesList.Count; q++)
                {
                    for (int j = 0; j < NodesList[q].Edges.Count; j++)
                    {
                        if (NodesList[q].Edges[j].RightNode == FindByXY(x, y) || NodesList[q].Edges[j].LeftNode == FindByXY(x, y))
                        {
                            NodesList[q].Edges[j] = null;
                            NodesList[q].Edges.RemoveAt(j);
                            j--;
                        }
                    }
                }

                if (FindByXY(x, y).Edges != null)
                {
                    for (int i = 0; i < FindByXY(x, y).Edges.Count; i++)
                    {
                        FindByXY(x, y).Edges[i] = null;
                        FindByXY(x, y).Edges.RemoveAt(i);
                        i--;
                    }
                }

                for (int k = 0; k < NodesList.Count; k++)
                {
                    if (NodesList[k] == FindByXY(x, y))
                    {
                        NodesList[k] = null;
                        NodesList.RemoveAt(k);
                        k--;
                        break;
                    }
                }
            }

            for (int q = 0; q < NodesList.Count; q++)
            {
                for (int j = 0; j < NodesList[q].Edges.Count; j++)
                {
                    if (NodesList[q].Edges[j].RightNode == null || NodesList[q].Edges[j].LeftNode == null)
                    {
                        NodesList[q].Edges[j] = null;
                        NodesList[q].Edges.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int n = 0; n < EdgesList.Count; n++)
            {
                if (EdgesList[n].RightNode == null || EdgesList[n].LeftNode == null)
                {
                    EdgesList[n] = null;
                    EdgesList.RemoveAt(n);
                    n--;
                }
            }
        }

        public void SaveGraph(string saveFileName)
        {
            StreamWriter writer = new StreamWriter(saveFileName, true, Encoding.Default);
            for (int i = 0; i < NodesList.Count; i++)
            {
                writer.WriteLine(NodesList[i].Name);
                writer.WriteLine(NodesList[i].X0);
                writer.WriteLine(NodesList[i].Y0);
                //writer.WriteLine(NodesList[i].CostOfNetwork);
            }
            writer.WriteLine("NODESDONE");

            for (int i = 0; i < EdgesList.Count; i++)
            {
                writer.WriteLine(EdgesList[i].Weight);
                writer.WriteLine(EdgesList[i].RightNode.X0);
                writer.WriteLine(EdgesList[i].RightNode.Y0);
                writer.WriteLine(EdgesList[i].LeftNode.X0);
                writer.WriteLine(EdgesList[i].LeftNode.Y0);
            }
            writer.WriteLine("EDGESDONE");

            writer.Close();
        }

        public Graph LoadGraph(string loadFileName)
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
                //node.CostOfNetwork = Convert.ToInt32(reader.ReadLine());
                graphRGraph.NodesList.Add(node);
            }

            while ((line = reader.ReadLine()) != "EDGESDONE")
            {
                EdgeGraph edge = new EdgeGraph();
                edge.Weight = Convert.ToInt32(line);
                //edge.IsBuilt = Convert.ToBoolean(reader.ReadLine());
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
            reader.Close();
            return graphRGraph;
        }
    }
}
