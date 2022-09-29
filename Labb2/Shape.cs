using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Labb2
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }   
}
