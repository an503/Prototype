using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Serializable]
    public class FlowerBouquet
    {
        public string Name { get; set; }

        public string Size { get; set; }

        public int Pack { get; set; }

        public string Tape { get; set; }

        internal static object DeepCopy()
        {
            throw new NotImplementedException();
        }
    }
}
