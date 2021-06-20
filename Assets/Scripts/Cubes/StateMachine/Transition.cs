using UnityEngine;

namespace Cubes.StateMachine
{
    public abstract class Transition : MonoBehaviour
    {
        [SerializeField] private State _targetState;

        private bool _needTransit;

        public State TargetState => _targetState;

        public bool NeedTransit => _needTransit;

        private void OnEnable()
        {
            SetNeedTransit(false);
        }

        public void SetActive(bool isActive)
        {
            enabled = isActive;
        }

        protected void SetNeedTransit(bool isActive)
        {
            _needTransit = isActive;
        }
    }
}
