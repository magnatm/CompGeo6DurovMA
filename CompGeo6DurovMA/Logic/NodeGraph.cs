using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGeo6DurovMA.Logic
{
    public class NodeGraph
    {
        public string Name { get; set; }
        public bool IsDrawn { get; set; }
        public int X0 { get; set; } 
        public int Y0 { get; set; }
        public List<EdgeGraph> Edges { get; set; }
    }
}
