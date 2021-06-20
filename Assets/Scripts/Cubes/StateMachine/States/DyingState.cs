using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
