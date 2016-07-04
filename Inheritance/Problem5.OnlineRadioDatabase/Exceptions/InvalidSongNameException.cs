namespace Problem5.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        private new const string Message = "Song name should be between 3 and 30 symbols.";
        public InvalidSongNameException() : base(Message)
        {
        }
    }
}