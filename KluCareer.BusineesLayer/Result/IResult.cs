using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Result
{
    public interface IResult
    {
        bool IsSuccess { get; set; }
        List<ResultMessage> Messages { get; set; }
    }
}
