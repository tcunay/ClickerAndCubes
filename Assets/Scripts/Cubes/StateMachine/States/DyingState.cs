namespace Cubes.StateMachine
{
    public class DyingState : State
    {
        private void Start()
        {
            Destroy(gameObject);
        }
    }
}
