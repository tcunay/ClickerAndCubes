using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cubes
{
    public struct CubeStats
    {
        private float _speed;
        private float _distance;

        public float Speed => _speed;

        public float Distance => _distance;

        public CubeStats(float speed, float distance)
        {
            _speed = speed;
            _distance = distance;
        }
    }
}
