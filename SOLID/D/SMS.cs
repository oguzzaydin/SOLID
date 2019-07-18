namespace SOLID.D
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
