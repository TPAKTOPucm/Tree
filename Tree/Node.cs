using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node : IEvaluable
    {
        public string Question { get; set; }
        public IEvaluable Posivive { get; set; }
        public IEvaluable Negative { get; set; }
        public bool Test(IAnswersSet answers)
        {
            return answers.getAnswer(Question);
        }
        public object Evaluate(IAnswersSet value)
        {
            if (Test(value))
            {
                return Posivive.Evaluate(value);
            }
            return Negative.Evaluate(value);
        }
    }
}
