using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class ThuCung
    {
        protected float chieuCao;
        protected float canNang;
        protected int tuoiTho;

        public float ChieuCao { get => chieuCao; set => chieuCao = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public int TuoiTho { get => tuoiTho; set => tuoiTho = value; }

        public ThuCung()
        {
            chieuCao = 5;
            canNang = 5;
            tuoiTho = 10;
        }

        public ThuCung(float chieuCao, float canNang, int tuoiTho)
        {
            this.chieuCao = chieuCao;
            this.canNang = canNang;
            this.tuoiTho = tuoiTho;
        }

        public ThuCung(float chieuCao, float canNang = 30)
        {
            this.chieuCao = chieuCao;
            this.canNang = canNang;
        }
        public void info()
        {
            Console.WriteLine("Thu Cung");
        }
    }
}
