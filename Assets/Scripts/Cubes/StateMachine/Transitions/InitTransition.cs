namespace Cubes.StateMachine
{
    public class InitTransition : Transition
    {
        private void Start()
        {
            SetNeedTransit(true);
        }
    }
}
