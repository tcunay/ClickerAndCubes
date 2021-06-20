using System.Collections.Generic;
using UnityEngine;

namespace Cubes.StateMachine
{
    public abstract class State : MonoBehaviour
    {
        [SerializeField] private List<Transition> _transitions;

        public void Enter()
        {
            if (IsActive() == false)
            {
                SetActive(true);

                foreach (var transition in _transitions)
                {
                    transition.SetActive(true);
                }
            }
        }

        public void Exit()
        {
            if (IsActive() == true)
            {
                foreach (var transition in _transitions)
                {
                    transition.SetActive(false);
                }

                SetActive(false);
            }
        }

        public State GetNextState()
        {
            foreach (var transition in _transitions)
            {
                if (transition.NeedTransit)
                {
                    return transition.TargetState;
                }
            }

            return null;
        }

        private void SetActive(bool isActive)
        {
            enabled = isActive;
        }

        private bool IsActive()
        {
            return enabled;
        }
    }
}
