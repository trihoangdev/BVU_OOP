using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Meo : ThuCung
    {
        private string mauLong;
        private float chieuDaiDuoi;
        public Meo() : base()
        {

        }
        public Meo(float chieuCao, float canNang, int tuoiTho) : base(chieuCao, canNang, tuoiTho)
        {
        }

        public Meo(float chieuCao, float canNang, int tuoiTho, string mauLong, float chieuDaiDuoi)
            : base(chieuCao, canNang, tuoiTho)
        {
            this.mauLong = mauLong;
            this.chieuDaiDuoi = chieuDaiDuoi;
        }

        public string MauLong { get => mauLong; set => mauLong = value; }
        public float ChieuDaiDuoi { get => chieuDaiDuoi; set => chieuDaiDuoi = value; }
        public new void info()
        {
            Console.WriteLine("Meo");
        }
    }
}
