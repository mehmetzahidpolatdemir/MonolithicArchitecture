using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Result
{
    public class SuccessResult : IResult
    {
        public bool IsSuccess { get ; set ; }
        public List<ResultMessage> Messages { get; set; }
        public SuccessResult()
        {
            IsSuccess = true;
        }

        public void AddMessage(string key,string message)
        {
            if (Messages==null)
            {
                Messages = new List<ResultMessage>();
            }
            Messages.Add(new ResultMessage(key,message));
        }
    }
}
