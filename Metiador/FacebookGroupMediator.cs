namespace Metiador
{
    //Concrete Mediator
    public class FacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> _usersList = new List<User>();
        public void RegisterUser(User user)
        {
            _usersList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var u in _usersList)
            {
                // mensagem não é sera recebida por quem a estiver enviando
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}
