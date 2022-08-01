using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //LSP
    interface ITakePhoto{
        public abstract void TakePhoto();
    }
    internal abstract class Phone
    {
        public abstract void Call();
    }

    internal class IPhone : Phone, ITakePhoto
    {
        public override void Call()
        {
            Console.WriteLine("Arama yapıldı! (IPhone)");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi! (IPhone)");
        }
    }

    internal class Nokia3310 : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Arama yapıldı! (Nokia3310)");

        }
    }
}
