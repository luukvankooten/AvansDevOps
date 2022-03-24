using System;
namespace Domain.Models.Sprints.Close
{
    public class ReviewBehavior: ICloseBehavior
    {
        public ReviewBehavior()
        {
        }

        public void Close(Sprint sprint)
        {
            if(sprint.Document != null)
            {
                throw new InvalidProgramException("Document must be uploaded");
            }

            return;
        }
    }
}
