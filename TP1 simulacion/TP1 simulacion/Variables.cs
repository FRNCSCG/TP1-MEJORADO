using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_simulacion
{
    class Variables
    {
        private float x;
        private float a;
        private float c;
        private float k;
        private float g;
        private float m;
        private float xsig;

        public Variables()
        {
        }

        public float X { get => x; set => x = value; }
        public float A { get => a; set => a = value; }
        public float C { get => c; set => c = value; }
        public float K { get => k; set => k = value; }
        public float M { get => m; set => m = value; }
        public float Xsig { get => xsig; set => xsig = value; }
        public float G { get => g; set => g = value; }
    }
}
