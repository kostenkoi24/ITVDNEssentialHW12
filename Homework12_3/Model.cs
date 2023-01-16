using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12_3
{
    class Model
    {
        private int increment;
        public string SomeMthod(string s)
        {
            return increment++.ToString();
        }

        public int Reset()
        {
            return increment = 0;
        }



    }
}
