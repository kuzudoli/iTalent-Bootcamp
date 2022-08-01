using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //LSP
    internal abstract class Phone
    {
        public abstract void Call();
        public abstract void TakePhoto();
    }

    internal class IPhone : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Arama yapıldı! (IPhone)");
        }

        public override void TakePhoto()
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

        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
