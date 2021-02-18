using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //Aşağıda oluşturduğumuz class lar sayesinde true yi default olarak vermiş olduk
        public SuccessResult(string message):base(true, message)
        {

        }

        public SuccessResult():base(true)
        {

        }
    }
}
