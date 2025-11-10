namespace MediatorPatternChat.Classes
{
    public class User
    {
        public string Name { get; set; }

        private ChatRoom _chatRoom;

        public User(string name)
        {
            Name = name;

            _chatRoom = ChatRoom.GetInstance();

            _chatRoom.AddUser(this);
        }

        public void SendMessage(string message)
        {
            _chatRoom.DisplayMessages(this, message);
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
