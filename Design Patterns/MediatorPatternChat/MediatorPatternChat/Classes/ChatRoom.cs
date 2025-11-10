namespace MediatorPatternChat.Classes
{
    public class ChatRoom
    {
        private static ChatRoom _chatRoom; 

        private List<User> users = new List<User>();

        public static ChatRoom GetInstance()
        {
            if (_chatRoom == null)
            {
                _chatRoom = new ChatRoom();
            }
            return _chatRoom;
        }

        public void DisplayMessages(User user, string message)
        {
            foreach(var u in users)
            {
                if (u != user)
                    u.RecieveMessage($"{user.Name}: {message}");
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
