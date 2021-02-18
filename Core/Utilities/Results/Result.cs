using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this --> class ın kendisi demektir.
        public Result(bool success, string message) : this(success) // Bu class çalışsın ve Result un tek parametrelı class ı da çalışsın
        {
            Message = message; // Readonly ler construction içinde set edilebilir.
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
