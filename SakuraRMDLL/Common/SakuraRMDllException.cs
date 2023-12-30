namespace SakuraRMDLL.Common
{
    [Serializable]
    public class SakuraRMDllException : Exception
    {
        public SakuraRMDllException() : base() { }
        public SakuraRMDllException(string message) : base(message) { }
        public SakuraRMDllException(string message, Exception innerException) : base(message, innerException) { }
    }
}
