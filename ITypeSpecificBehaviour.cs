using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_18_GenericApproch
{
    public interface ITypeSpecificBehaviour<T>
    {
        string Gettypespecificbehaviour<T>(T data) where T : Animal;
    }
}
