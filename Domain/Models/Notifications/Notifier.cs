using System;
using System.Collections.Generic;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
    public class Notifier
    {
        public BacklogContext BacklogContext { get; }

        

        public Notifier(BacklogContext backlogContext)
        {
            BacklogContext = backlogContext;
        }

        
        public void ChangeState(BacklogContext backlogContext)
        {

        }
    }
}
