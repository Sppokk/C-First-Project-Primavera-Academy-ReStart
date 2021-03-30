using System;
using System.Collections.Generic;
using System.Text;

namespace Movie4AllCsharpPT
{
    public class Console2
    {
        public static int ReadInt()
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            return num;
        }
    }
}
