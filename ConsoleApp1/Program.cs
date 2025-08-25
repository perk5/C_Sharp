using System;
using System.IO;
using System.Runtime.Serialization;

class CustomExceptionsDemo
{
    public static void Main()
    {
        throw new UserAlreadyLoggedInException("User is logged in");  
    }
}

public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }

    public UserAlreadyLoggedInException(string message) : base(message)
    {
          
    }

    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}