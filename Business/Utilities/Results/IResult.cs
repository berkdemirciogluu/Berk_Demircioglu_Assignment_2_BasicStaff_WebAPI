using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.Results
{
    //This is created for methods that return void.
    public interface IResult
    {
        bool Success { get; } //The property that indicates the result of the method.
        string Message { get; } //The property that gives an informative message.

    }
}
