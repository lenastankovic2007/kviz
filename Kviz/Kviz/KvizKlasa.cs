using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kviz
{
    class KvizKlasa
    {
        public QuestionBank Questions { get; private set; }
        public int Poeni { get; set; }

        public KvizKlasa()
        {
            Questions = new QuestionBank();
            Poeni = 0;
        }

    }
}
