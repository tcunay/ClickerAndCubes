using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
