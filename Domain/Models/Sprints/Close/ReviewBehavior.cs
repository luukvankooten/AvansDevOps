using System;
namespace Domain.Models.Sprints.Close
{
    public class Review: ICloseBehavior
    {
        public Review()
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
