using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Class
{
    public class ResponseMessage
    {
        public Message_Model Respon = new Message_Model();
        public object Data { get; set; }
        //public void Data2<T>(T input) {  }
    }

    public class Message_Model
    {

        public Boolean Result { get; set; }
        public string Result_value { get; set; }
        public string Result_value2 { get; set; }
        public string Result_value3 { get; set; }
        public string ErrorMessage { get; set; }
        public string SystemErrorMessage { get; set; }

        //public void Data_list<T>( ref T input2)
        //{
        //    //T temp = default(T);
        //    return input2;
        //}

        //static void Main(string[] args)
        //{
        //    int first = 4;
        //    int second = 5;

        //    Swap<int>(ref first, ref second);
        //}




    }

}