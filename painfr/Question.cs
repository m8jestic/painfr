using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painfr
{
    public abstract class Question
    {
        public abstract string text { get; set; }
        public abstract List<Answer> answers { get; set; }

    }
}
