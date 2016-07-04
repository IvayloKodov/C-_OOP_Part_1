namespace Problem5.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public new const string Message = "Invalid song length.";
        public InvalidSongLengthException() : base(Message)
        {
        }
        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}