using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cubes.StateMachine
{
    [RequireComponent(typeof(MoveToDistanceState))]
    public class DistanceTransiton : Transition
    {
        private MoveToDistanceState _moveToDistanceState;

        private void Awake()
        {
            _moveToDistanceState = GetComponent<MoveToDistanceState>();
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
