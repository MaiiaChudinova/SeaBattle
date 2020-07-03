using SeaBattle.Models;

namespace SeaBattle.Services.Messages
{
    public class LoginInfoMessage : IMessage
    {
        public UserModel User { get; set; }
    }
}
