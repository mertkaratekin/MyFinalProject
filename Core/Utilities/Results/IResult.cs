using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Successs { get; } /*get = okumak için,  set = yazmak için*/
        string Message { get; }

    }
}
