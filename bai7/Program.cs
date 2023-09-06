﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo sc = new ToaDo();
            sc.Ten = "O";
            sc.X = 5;
            sc.Y = 5;
            HinhTron ht = new HinhTron(sc, 10.5);
            Console.WriteLine("Hinh tron co tam la{0}({1},{2}) voi ban kinh la {3} co dien tich va chu vi la {4} và {5}", td.Ten, td.X, td.Y, ht.BanKinh, Math.Round(ht.tinhDienTich(), 3), Math.Round(ht.tinhChuVi(), 3));
            Console.ReadLine();
        }
    }
}
