using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompGeo6DurovMA.Logic;
using CompGeo6DurovMA.Utils;

namespace CompGeo6DurovMA
{
    public partial class FormMain : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Graphics g;
        private Graph graph;
        private Rectangle rect;

        public FormMain()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            graph = new Graph();

            WindowState = FormWindowState.Maximized;
            openFileDialog.DefaultExt = ".txt";
            saveFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "(*.txt) | *.txt";
            saveFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;

            groupBoxChecks.Controls.Add(radioButtonAddNode);
            groupBoxChecks.Controls.Add(radioButtonDelNode);
            groupBoxChecks.Controls.Add(radioButtonMoveNode);
            groupBoxChecks.Controls.Add(radioButtonAddEdge);
            groupBoxChecks.Controls.Add(radioButtonDelEdge);

            groupBoxNode.Controls.Add(radioButtonRoundNode);
            groupBoxNode.Controls.Add(radioButtonSquareNode);
            radioButtonRoundNode.Checked = true;

            textBoxAddNode.MaxLength = 10;
            textBoxAddNode.Text = "аа";

            g = pictureBoxMain.CreateGraphics();
            rect = pictureBoxMain.ClientRectangle;
            rect.Width-=2;
            rect.Height--;
        }

        private string GrowNodeName(string startName)
        {
            string str = String.Empty;
            char c = startName[0];
            char e = startName[1];

            if (e == 'я' && c == 'я')
            {
                str = "aa";
            }
            else
            {
                if (e == 'я')
                {
                    c++;
                    e = 'а';
                    str = c.ToString() + e;
                }
                else
                {
                    e++;
                    str = c.ToString() + e;
                }
            }

            return str;
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr2 = pictureBoxMain.CreateGraphics();
            Bitmap bitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            Graphics g = Graphics.FromImage(bitmap);

            //g = pictureBoxMain.CreateGraphics();
            this.g.Clear(Color.AliceBlue);
            this.g.DrawRectangle(Pens.BlueViolet, rect);
            if (radioButtonAddNode.Checked)
            {
                
                if (textBoxAddNode.Text != "")
                {
                    int k = graph.GetNodesListCount();
                    if (radioButtonRoundNode.Checked)
                    {
                        graph.AddNode(e.X, e.Y, textBoxAddNode.Text, buttonNodeColor.BackColor,
                            buttonNodeFill.BackColor, buttonFontColor.BackColor,true);
                    }

                    if (radioButtonSquareNode.Checked)
                    {
                        graph.AddNode(e.X, e.Y, textBoxAddNode.Text, buttonNodeColor.BackColor,
                            buttonNodeFill.BackColor, buttonFontColor.BackColor, false);
                    }

                    if (k != graph.GetNodesListCount())
                    {
                        textBoxAddNode.Text = GrowNodeName(textBoxAddNode.Text);
                    }

                    DrawUtils.Draw(this.g, graph);
                }
            }


            if (radioButtonDelNode.Checked)
            {
                graph.DeleteNode(e.X, e.Y);
                DrawUtils.Draw(this.g, graph);
            }

            if (radioButtonMoveNode.Checked)
            {
                graph.MoveNode(e.X, e.Y);
                DrawUtils.Draw(this.g, graph);
            }

            if (radioButtonAddEdge.Checked)
            {
                graph.AddEdge(e.X, e.Y, buttonEdgeColor.BackColor, buttonArrowColor.BackColor);
                DrawUtils.Draw(this.g, graph);
            }

            if (radioButtonDelEdge.Checked)
            {
                graph.DeleteEdge(e.X, e.Y);
                // graph.HiglightEdge(e.X,e.Y);
                DrawUtils.Draw(this.g, graph);
            }
            gr2.DrawImage(bitmap, 0, 0);
        }

        private void buttonSaveGraph_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            GraphIOUtils.SaveGraph(graph,saveFileDialog.FileName);
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
            g = pictureBoxMain.CreateGraphics();
            g.Clear(Color.AliceBlue);
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            graph = GraphIOUtils.LoadGraph(openFileDialog.FileName);
            g.DrawRectangle(Pens.BlueViolet,rect);
            DrawUtils.Draw(g, graph);
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.AliceBlue);
            gr.DrawRectangle(Pens.BlueViolet,rect);
        }

        private void buttonNodeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonNodeColor.BackColor;
            colorDialog1.ShowDialog();
            buttonNodeColor.BackColor = colorDialog1.Color;
        }

        private void buttonNodeFill_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonNodeFill.BackColor;
            colorDialog1.ShowDialog();
            buttonNodeFill.BackColor = colorDialog1.Color;
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonFontColor.BackColor;
            colorDialog1.ShowDialog();
            buttonFontColor.BackColor = colorDialog1.Color;
        }

        private void buttonEdgeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonEdgeColor.BackColor;
            colorDialog1.ShowDialog();
            buttonEdgeColor.BackColor = colorDialog1.Color;
        }

        private void buttonArrowColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonArrowColor.BackColor;
            colorDialog1.ShowDialog();
            buttonArrowColor.BackColor = colorDialog1.Color;
        }
    }
}
