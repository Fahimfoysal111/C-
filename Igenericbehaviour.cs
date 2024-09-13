using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_18_GenericApproch
{
    public interface Igenericbehaviour<T>
    {
        string GenericBehaviour(T obj);
    }
}
