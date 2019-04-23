using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_netcore_pbt_demo
{
    public static class Arithmetic
    {
        public static int Multiply(int x, int y) => x * y;

        // Introduce Issue
        //public static int Multiply(int x, int y) => 
        //    x == -10 || y == 10 ? throw new Exception("sample issue") :x * y;
    }
}
