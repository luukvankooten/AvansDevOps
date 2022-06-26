using System;
using Domain.Models;
using Domain.Models.Notifications;

namespace Adapter
{
    /// <summary>
    /// Adapter pattern applied here
    /// </summary>
    public class EmailNotifier : ISprintObserver
    {
        private readonly EmailAdapter _adapter;

        public EmailNotifier(EmailAdapter adapter)
        {
            _adapter = adapter;
        }

        public void Update(Sprint sprint, Member[] members, string message)
        {
            foreach (var member in members)
            {
                _adapter.SendEmail(message, member.Email);
            }
        }

        public void Update(Item item, Member[] members, string message)
        {
            foreach (var member in members)
            {
                _adapter.SendEmail(message, member.Email);
            }
        }
    }
}