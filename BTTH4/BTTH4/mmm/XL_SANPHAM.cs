using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTTH4.mmm
{
    class XL_SANPHAM: XLBANG
    {
        public XL_SANPHAM(): base ("SANPHAM"){}
        public XL_SANPHAM(string pQuery) : base("SANPHAM", pQuery) { }
    }
}
