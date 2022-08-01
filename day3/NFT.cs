using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class NFT
    {
        public NFT()
        {
            id = 1;
            name = "Crypto Pengus";
        }
        public event Action<int> SoldEvent;
        private int id { get; set; }
        public string name { get; set; }
        public bool sold
        {
            get { return sold; }
            set
            {
                if (value == true)
                    SoldEvent(id);
                
                sold = value;    
            }
        }

        public void buy()
        {
            sold = true;
        }

    }
}
