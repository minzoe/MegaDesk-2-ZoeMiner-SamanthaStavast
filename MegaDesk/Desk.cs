using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public struct Desk
    {
        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public decimal Width { get; }
        public decimal Depth { get; }
        public int Drawers { get; }
        public SurfaceMaterial Material { get; }

        public Desk(decimal width, decimal depth, int drawers, SurfaceMaterial deskMaterial)
        {
            Width = width;
            Depth = depth;
            Drawers = drawers;
            Material = deskMaterial;
        }
    }
}
