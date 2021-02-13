using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)   // this -> class'ın kendisi(ex. Result) - aşağıdaki overload fonksiyonunu çalıştırır.
        {
            Message = message;
            //Success = success;    // success'i set etme işini aşağıdaki methoda bırakıyoruz. DRY!
        }

        public Result(bool success) // Sistemde mesaj iletmek istemiyor isek overload kullanarak sadece success döndürebiliriz.
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }  // 'get' -readonly- bir yapıdır ve sadece constructor'da set edilebilir.
                                        // Bu şekilde yaparak kodları kısıtlayarak standardize etmiş olduk.
    }
}
