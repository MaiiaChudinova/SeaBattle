namespace SeaBattle.Services.Messages
{
    public class TextMessage : IMessage
    {
        public TextMessage(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
