using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGeo6DurovMA.Logic
{
    public class EdgeGraph
    {
        public bool IsHighlighted { get; set; }
        public NodeGraph LeftNode { get; set; }
        public NodeGraph RightNode { get; set; }
        public Color EdgeColor { get; set; }
        public Color ArrowColor { get; set; }

        public EdgeGraph()
        {
            this.IsHighlighted = false;
        }
    }
}
