namespace HotelDemo.BusnissLogicLayer.Extended;

public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
        ErrorMessage = message;
    }

    public string ErrorMessage { get; }
}
