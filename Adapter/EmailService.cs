using System;

namespace Adapter
{   
    /// <summary>
    /// Normally a vendor for now its a demo
    /// Part of the Adapter pattern
    /// </summary>
    public class EmailService
    {
        public void SendEmail(string message, string email)
        {
            Console.WriteLine($"to: {email} message: {message}");
        }
    }
}