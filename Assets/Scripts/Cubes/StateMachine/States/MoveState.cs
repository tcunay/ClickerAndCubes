using UnityEngine;

namespace Cubes.StateMachine
{
    [RequireComponent(typeof(Cube))]
    public class MoveState : State
    {
        private Cube _cube;
        private Vector3 _startPosition;

        public float Distance => _cube.Stats.Distance;

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
            Move();
        }

        private void Move()
        {
            transform.Translate(Vector3.forward * _cube.Stats.Speed * Time.deltaTime);
        }
    }
}
