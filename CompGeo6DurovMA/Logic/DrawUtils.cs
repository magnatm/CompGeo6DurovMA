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
        public static Font FontNode = new Font("Arial", 15);
        public static Font FontEdge = new Font("Arial", 12);
    }
}
