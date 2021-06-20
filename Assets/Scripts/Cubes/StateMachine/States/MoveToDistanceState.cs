using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cubes.StateMachine
{
    [RequireComponent(typeof(Cube))]
    public class MoveToDistanceState : State
    {
        private Cube _cube;
        private Vector3 _startPosition;
        private float _distance;
        private float _speed;

        public float Distance => _distance;

        public float DistanceTraveled => (transform.position - _startPosition).magnitude;

        private void Awake()
        {
            _cube = GetComponent<Cube>();
        }

        private void OnEnable()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            TryMove();
        }

        private void TryMove()
        {
            if (true)
                Move();
        }

        private void Move()
        {
            transform.position = Vector2.MoveTowards(transform.position, Vector3.forward * _distance, _speed * Time.deltaTime);
        }
    }
}
