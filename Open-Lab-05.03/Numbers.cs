using System;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)=>num.ToString("N0").Replace(' ', ',');


    }
}
