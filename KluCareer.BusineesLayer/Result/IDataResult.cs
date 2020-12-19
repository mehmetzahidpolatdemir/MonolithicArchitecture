using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Result
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; set; }
    }
}
