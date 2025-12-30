namespace PartyRaidR.Backend.Exceptions
{
    [Serializable]
    internal class RegistrationWithTakenUsernameException : Exception
    {
        public RegistrationWithTakenUsernameException()
        {
        }

        public RegistrationWithTakenUsernameException(string? message) : base(message)
        {
        }

        public RegistrationWithTakenUsernameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}