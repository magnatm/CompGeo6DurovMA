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
        public List<NodeGraph> NodesList = new List<NodeGraph>();
        public List<EdgeGraph> EdgesList = new List<EdgeGraph>();

        public int GetNodesListCount()
        {
            return NodesList.Count;
        }

        public int GetEdgesListCount()
        {
            return EdgesList.Count;
        }

        public void AddNode(int x, int y, string name, Color borderColor, Color fillColor, Color fontColor, bool isEllipse)
        {
            if (FindByXY(x, y) == null)
            {
                NodeGraph node = new NodeGraph();
                node.X0 = x;
                node.Y0 = y;
                node.Name = name;
                node.Edges = new List<EdgeGraph>();
                node.BorderColor = borderColor;
                node.FillColor = fillColor;
                node.FontColor = fontColor;
                node.IsEllipse = isEllipse;
                NodesList.Add(node);
            }
        }

        public NodeGraph NodeForMove;

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
        public void AddEdge(int x, int y, Color edgeColor, Color arrowColor)
        {
            if (EdgeGraphAdd == null)
            {
                EdgeGraphAdd = new EdgeGraph();
                EdgeGraphAdd.ArrowColor = arrowColor;
                EdgeGraphAdd.EdgeColor = edgeColor;
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
                    EdgesList.Add(EdgeGraphAdd);
                    EdgeGraphAdd = null;
                }
            }
        }

        public void DeleteEdge(int x, int y) /////////////////////////////////////////////////////////////////////
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

        public NodeGraph FindByXY(int x, int y) // нахождение вершины по координатам через мышку
        {
            foreach (NodeGraph p in NodesList)
            {
                if (p != null)
                {
                    if ((p.X0 - x) * (p.X0 - x) + (p.Y0 - y) * (p.Y0 - y) < 30 * 30)
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
    }
}
