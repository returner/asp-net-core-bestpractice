namespace AppCommon.Exceptions
{
    public class DtoNullException : Exception
    {
        public string? ParameterName { get; }
        public DtoNullException(string? paramName = null)
        {
            ParameterName = paramName;
        }
    }
}
