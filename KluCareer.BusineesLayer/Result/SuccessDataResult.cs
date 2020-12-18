using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Result
{
    public class SuccessDataResult<T>:IDataResult<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public List<ResultMessage> Messages { get; set; }
        public SuccessDataResult(T data)
        {
            IsSuccess = true;
            Data = data;
        }
        //addmessage("success","işlem başarılı..")
        public void AddMessage(string key,string message)
        {
            if (Messages == null)
            {
                Messages = new List<ResultMessage>();
            }
            Messages.Add(new ResultMessage(key,message));
        }
    }
}
