using System;

namespace DatingApp.API.Dtos
{
    public class CreateNewMessageDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime TimeSent { get; set; }
        public string Content { get; set; }
        public CreateNewMessageDto()
        {
            TimeSent = DateTime.Now.ToLocalTime();
        }
    }
}