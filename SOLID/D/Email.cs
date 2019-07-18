namespace SOLID.D
{
    public class Email: IMessage
    {
        public string IoAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
