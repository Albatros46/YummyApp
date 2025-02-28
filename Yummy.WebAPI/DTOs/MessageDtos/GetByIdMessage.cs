namespace Yummy.WebAPI.DTOs.MessageDtos
{
    public class GetByIdMessage
    {
        public int Id { get; set; }
        public string nameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime sendDate { get; set; }
        public bool isRead { get; set; }
    }
}
