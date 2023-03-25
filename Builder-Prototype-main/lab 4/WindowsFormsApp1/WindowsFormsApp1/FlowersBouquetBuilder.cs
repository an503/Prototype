using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class FlowerBouquetBuilder
    {
        private FlowerBouquet _flowerbouquet;

        public FlowerBouquetBuilder()
        {
            _flowerbouquet = new FlowerBouquet();
        }

        public void SetName(string name)
        {
            _flowerbouquet.Name = name;
        }

        public void SetSize(string size)
        {
            _flowerbouquet.Size = size;
        }

        public void SetTape(string tape)
        {
            _flowerbouquet.Tape = tape;
        }
        public void SetPack(string pack)
        {
            _flowerbouquet.Pack = pack;
        }

        public FlowerBouquet GetFlowerBouquet()
        {
            return _flowerbouquet;
        }

        internal void SetPack(int pack)
        {
            throw new NotImplementedException();
        }

        internal object GetFlowersBouquet()
        {
            throw new NotImplementedException();
        }
    }
}
