namespace Metiador
{
    //Colleague
    public abstract class User
    {
        protected IFacebookGroupMediator _mediator;
        protected string _name;

        public User(IFacebookGroupMediator mediator, string name)
        {
            this._mediator = mediator;
            this._name = name;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}
