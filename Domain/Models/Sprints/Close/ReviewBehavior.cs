using System;
namespace Domain.Models.Sprints.Close
{
    public class ReviewBehavior: ICloseBehavior
    {
        public void Close(Sprint sprint)
        {
            if(sprint.Document == null)
            {
                throw new InvalidProgramException("Document must be uploaded");
            }

            return;
        }
    }
}
