using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGeo6DurovMA.Logic
{
    public static class DrawUtils
    {
        public static Pen PenLine = new Pen(Color.DeepPink);
        public static Pen PenLineSpecial = new Pen(Color.DarkGreen, 4);
        public static Pen PenNode = new Pen(Color.DarkViolet);
        public static Pen CrimsonPenNode = new Pen(Color.Crimson);
        public static SolidBrush BrushBackground = new SolidBrush(Color.NavajoWhite);
        public static SolidBrush BrushBackHighLight = new SolidBrush(Color.LemonChiffon);
        public static SolidBrush BrushNodeData = new SolidBrush(Color.Black);
        public static SolidBrush BrushEdgesDataSpecial = new SolidBrush(Color.Crimson);
        public static Font FontNode = new Font("Arial", 13);

        public static void Draw(Graphics g, Graph graph)
        {
            foreach (NodeGraph x in graph.NodesList)
            {
                if (x != null)
                {
                    x.IsDrawn = false;
                }
            }
            foreach (NodeGraph x in graph.NodesList)
            {
                if (x != null)
                {
                    Draw(g, x, graph); // передаем один из узлов
                }
            }
        }

        private static void Draw(Graphics g, NodeGraph p, Graph graph)
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
                                    DrawEdge(g, p, e.LeftNode, false,e);
                            }
                        }

                        if (p == e.LeftNode)
                        {
                            if (e.RightNode != null)
                            {
                                if (!e.RightNode.IsDrawn)
                                    DrawEdge(g, p, e.RightNode, true,e);
                            }
                        }
                    }
                }
            }

            DrawNode(g, p, graph);
            p.IsDrawn = true;
        }

        private static void DrawEdge(Graphics g, NodeGraph p, NodeGraph n, bool IsNRight, EdgeGraph edge)////////////////////////////////////////////DORABOTATb
        {
            //g.DrawLine(DrawUtils.PenLine, p.X0, p.Y0, n.X0, n.Y0);

            g.DrawLine(new Pen(edge.EdgeColor), p.X0 , p.Y0, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2);
            g.DrawLine(new Pen(edge.EdgeColor), p.X0 , p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2);
            g.DrawLine(new Pen(edge.EdgeColor), n.X0 , p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0);

            if (IsNRight)
            {

                if (n.Y0 < p.Y0)
                {
                    DrawUpArrow(g, p.X0, p.Y0, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2,edge);
                    DrawUpArrow(g, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0, edge);
                }
                else
                {
                    DrawDownArrow(g, p.X0, p.Y0, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2, edge);
                    DrawDownArrow(g, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0, edge);
                }

                if (n.X0 > p.X0)
                {
                    DrawLtoRArrow(g, p.X0, p.Y0, n.X0, n.Y0, edge);
                }
                else
                {
                    DrawRtoLArrow(g, p.X0, p.Y0, n.X0, n.Y0, edge);
                }
            }
            else
            {
                if (n.Y0 > p.Y0)
                {
                    DrawUpArrow(g, p.X0, p.Y0, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2, edge);
                    DrawUpArrow(g, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0, edge);
                }
                else
                {
                    DrawDownArrow(g, p.X0, p.Y0, p.X0, p.Y0 + (n.Y0 - p.Y0) / 2, edge);
                    DrawDownArrow(g, n.X0, p.Y0 + (n.Y0 - p.Y0) / 2, n.X0, n.Y0, edge);
                }

                if (n.X0 > p.X0)
                {
                    DrawRtoLArrow(g, p.X0, p.Y0, n.X0, n.Y0, edge);
                }
                else
                {
                    DrawLtoRArrow(g, p.X0, p.Y0, n.X0, n.Y0, edge);
                }
            }
        }

        private static void DrawUpArrow(Graphics g, int px, int py, int nx, int ny, EdgeGraph edge)
        {
            if (Math.Abs(ny - py) > 15)
            {
                g.DrawLine(new Pen(edge.ArrowColor), px, (ny - py) / 2 + py, px + 5, (ny - py) / 2 + 5 + py);
                g.DrawLine(new Pen(edge.ArrowColor), px, (ny - py) / 2 + py, px - 5, (ny - py) / 2 + 5 + py);
            }
        }

        private static void DrawDownArrow(Graphics g, int px, int py, int nx, int ny, EdgeGraph edge)
        {
            if (Math.Abs(ny - py) > 15)
            {
                g.DrawLine(new Pen(edge.ArrowColor), px, (ny - py) / 2 + py, px + 5, (ny - py) / 2 - 5 + py);
                g.DrawLine(new Pen(edge.ArrowColor), px, (ny - py) / 2 + py, px - 5, (ny - py) / 2 - 5 + py);
            }
        }

        private static void DrawLtoRArrow(Graphics g, int px, int py, int nx, int ny, EdgeGraph edge)
        {
            if (Math.Abs(nx - px) > 15)
            {
                g.DrawLine(new Pen(edge.ArrowColor), (px + nx) / 2 - 5, py + (ny - py) / 2 + 5, (px + nx) / 2 + 5, py + (ny - py) / 2);
                g.DrawLine(new Pen(edge.ArrowColor), (px + nx) / 2 - 5, py + (ny - py) / 2 - 5, (px + nx) / 2 + 5, py + (ny - py) / 2);
            }
        }

        private static void DrawRtoLArrow(Graphics g, int px, int py, int nx, int ny, EdgeGraph edge)
        {
            if (Math.Abs(nx - px) > 15)
            {
                g.DrawLine(new Pen(edge.ArrowColor), (px + nx) / 2 + 5, py + (ny - py) / 2 + 5, (px + nx) / 2 - 5, py + (ny - py) / 2);
                g.DrawLine(new Pen(edge.ArrowColor), (px + nx) / 2 + 5, py + (ny - py) / 2 - 5, (px + nx) / 2 - 5, py + (ny - py) / 2);
            }
        }

        private static void DrawNode(Graphics g, NodeGraph p, Graph graph)
        {
            if (p.IsEllipse)
            {
                if (p == graph.NodeForMove)
                {
                    g.FillEllipse(DrawUtils.BrushBackHighLight, p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                    g.DrawEllipse(DrawUtils.CrimsonPenNode, p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                }
                else
                {
                    g.FillEllipse(new SolidBrush(p.FillColor), p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                    g.DrawEllipse(new Pen(p.BorderColor), p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                }
            }
            else
            {
                if (p == graph.NodeForMove)
                {
                    g.FillRectangle(DrawUtils.BrushBackHighLight, p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                    g.DrawRectangle(DrawUtils.CrimsonPenNode, p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(p.FillColor), p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                    g.DrawRectangle(new Pen(p.BorderColor), p.X0 - p.GetWidth() / 2, p.Y0 - 20, p.GetWidth(), 40);
                }
            }

            if (p.Name.Length < 4)
            {
                g.DrawString(p.Name, DrawUtils.FontNode, new SolidBrush(p.FontColor), p.X0 - p.GetWidth()/4,
                    p.Y0 - 12);
            }
            if (p.Name.Length < 7 && p.Name.Length >=4)
            {
                g.DrawString(p.Name, DrawUtils.FontNode, new SolidBrush(p.FontColor), p.X0 - p.GetWidth()/3,
                    p.Y0 - 12);
            }
            if (p.Name.Length >= 7)
            {
                g.DrawString(p.Name, DrawUtils.FontNode, new SolidBrush(p.FontColor), p.X0 +10- p.GetWidth() / 2,
                    p.Y0 - 12);
            }
        }
    }
}
