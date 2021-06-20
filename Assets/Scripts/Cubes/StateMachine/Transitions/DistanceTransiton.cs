using UnityEngine;

namespace Cubes.StateMachine
{
    [RequireComponent(typeof(MoveState))]
    public class DistanceTransiton : Transition
    {
        private MoveState _moveToDistanceState;

        private void Awake()
        {
            _moveToDistanceState = GetComponent<MoveState>();
        }

        private void Update()
        {
            TryActiveNeedTransit();
        }

        private void TryActiveNeedTransit()
        {
            if (_moveToDistanceState.DistanceTraveled >= _moveToDistanceState.Distance)
            {
                SetNeedTransit(true);
            }
        }
    }
}
