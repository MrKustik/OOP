namespace Bridge
{
    public abstract class RemoteControl
    {
        protected ITelevision _television;

        public RemoteControl(ITelevision television)
        {
            _television = television;
        }

        public virtual void On()
        {
            _television.OnOff(true);
        }

        public virtual void Off()
        {
            _television.OnOff(false);
        }

        public virtual void SetChannel(int channel)
        {
            _television.ChoiseChannel(channel);
        }
    }
}