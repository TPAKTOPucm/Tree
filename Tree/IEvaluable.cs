using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public interface IEvaluable
    {
        object Evaluate(IAnswersSet value);
    }
}
