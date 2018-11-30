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
            textBoxAddNode.MaxLength = 2;
            textBoxWeight.MaxLength = 3;
            textBoxAddNode.Text = "аа";
            textBoxWeight.Text = "10";

            g = pictureBoxMain.CreateGraphics();
            rect = pictureBoxMain.ClientRectangle;
            rect.Width--;
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
            g = pictureBoxMain.CreateGraphics();
            g.Clear(Color.AliceBlue);
            g.DrawRectangle(Pens.BlueViolet, rect);
            if (radioButtonAddNode.Checked)
            {
                if (textBoxAddNode.Text != "")
                {
                    int k = graph.GetNodesListCount();
                    graph.AddNode(e.X, e.Y, textBoxAddNode.Text);
                    if (k != graph.GetNodesListCount())
                    {
                        textBoxAddNode.Text = GrowNodeName(textBoxAddNode.Text);
                    }
                    graph.Draw(g);
                }
            }

            if (radioButtonDelNode.Checked)
            {
                graph.DeleteNode(e.X, e.Y);
                graph.Draw(g);
            }

            if (radioButtonMoveNode.Checked)
            {
                graph.MoveNode(e.X, e.Y);
                graph.Draw(g);
            }

            if (radioButtonAddEdge.Checked)
            {
                try
                {
                    graph.AddEdge(e.X, e.Y, Convert.ToInt32(textBoxWeight.Text));
                }
                catch
                {
                    textBoxWeight.Clear();
                    MessageBox.Show("Введите вес корректно!");
                }
                graph.Draw(g);
            }

            if (radioButtonDelEdge.Checked)
            {
                graph.DeleteEdge(e.X, e.Y);
                graph.Draw(g);
            }
        }

        private void buttonSaveGraph_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            graph.SaveGraph(saveFileDialog.FileName);
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
            g = pictureBoxMain.CreateGraphics();
            g.Clear(Color.AliceBlue);
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            graph = graph.LoadGraph(openFileDialog.FileName);
            graph.Draw(g);
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.AliceBlue);
            gr.DrawRectangle(Pens.BlueViolet,rect);
        }
    }
}
