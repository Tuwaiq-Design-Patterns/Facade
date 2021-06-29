namespace FacadeDemo
{
    public class TalkingFacade
    {
        protected Brain _brain;
        protected Lips _lips;
        protected Tongue _tongue;

        public TalkingFacade(Brain brain, Lips lips, Tongue tongue)
        {
            this._brain = brain;
            this._lips = lips;
            this._tongue = tongue;
        }


        public void LetsTalk()
        {
            _brain.WantTalking();
            _lips.WantTalking();
            _tongue.WantTalking();
        }
    }
}