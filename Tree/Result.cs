using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Result : IEvaluable
    {
        public Result(object result) { 
            ResultValue = result;
        }
        public object ResultValue { get; set; }
        public object Evaluate(IAnswersSet value)
        {
            return ResultValue;
        }
    }
}
