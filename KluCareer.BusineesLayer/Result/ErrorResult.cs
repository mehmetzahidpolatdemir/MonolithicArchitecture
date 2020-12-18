
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Result
{
    public class ErrorResult : IResult
    {
        public bool IsSuccess { get; set; }
        public List<ResultMessage> Messages { get ; set ; }
        public ErrorResult()
        {
            IsSuccess = false;
            Messages = new List<ResultMessage>();
        }
        public void AddMessage(string key, string message)
        {
            Messages.Add(new ResultMessage(key,message));
        }
    }
}
