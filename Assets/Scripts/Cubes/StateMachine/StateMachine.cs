using UnityEngine;

namespace Cubes.StateMachine
{

    public class StateMachine : MonoBehaviour
    {
        [SerializeField] private State _firstState;

        private State _currentState;

        public State Current => _currentState;

        private void Start()
        {
            Reset(_firstState);
        }

        private void Update()
        {
            TryTransit();
        }

        private void TryTransit()
        {
            if (_currentState == null)
                return;

            State nextState = _currentState.GetNextState();
            if (nextState != null)
            {
                Transit(nextState);
            }
        }

        private void Transit(State nextState)
        {
            if (_currentState != null)
            {
                _currentState.Exit();
            }
            _currentState = nextState;

            if (_currentState != null)
            {
                _currentState.Enter();
            }
        }

        private void Reset(State startState)
        {
            _currentState = startState;

            if (_currentState != null)
            {
                _currentState.Enter();
            }
        }
    }
}
