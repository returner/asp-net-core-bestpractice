namespace AppCommon.Exceptions
{
    public class UserKeyIsNullException : Exception
    {
        public string? UserKey { get; private set; }
        public UserKeyIsNullException(string? userKey)
        {
            UserKey = userKey;
        }
    }
}
