using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab9
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}