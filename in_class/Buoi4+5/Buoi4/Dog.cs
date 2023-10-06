using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Dog : ThuCung
    {
        private string mauLong;

        public Dog()  : base()
        {
        }

        public Dog(float chieuCao, float canNang, int tuoiTho) : base(chieuCao, canNang, tuoiTho)
        {
        }

    }
}
