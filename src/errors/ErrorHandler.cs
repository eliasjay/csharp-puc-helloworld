using System;

namespace trabalho1
{
  class ErrorHandler : System.Exception
  {
    public readonly String message;
    public readonly int statusCode;
    
    public ErrorHandler(String message, int statusCode = 400)
    {
      this.message = message;
      this.statusCode = statusCode;
    }
  }
}