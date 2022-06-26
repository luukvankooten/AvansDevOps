using System;
using System.Text;

namespace Adapter
{   
    /// <summary>
    /// Normally a vendor for now its a demo
    /// Part of the Adapter pattern
    /// </summary>
    public class EmailService
    {
        public StringBuilder builder = new();
        
        public void SendEmail(string message, string email)
        {
            builder.Append($"to: {email} message: {message}");
        }
    }
}