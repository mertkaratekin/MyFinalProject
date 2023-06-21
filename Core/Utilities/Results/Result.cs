using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message): this(success)/*iki parametreli veri geldiğinde tis success ı da çalıştırır */
        {
            Message = message;
        }

        public Result(bool success)
        {
            Successs = success;
        }

        public bool Successs { get; }

        public string Message { get; }

    }
}
