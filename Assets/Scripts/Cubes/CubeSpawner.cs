using UnityEngine;

namespace Cubes
{
    public class CubeSpawner : MonoBehaviour
    {
        [SerializeField] private Cube _template;
        [SerializeField] private Transform _contanier;

        private SpawnStats _spawnStats;
        private float _elapsedTime;
        private bool _allowedToSpawn;

        private void Update()
        {
            TrySpawn();
        }

        private void TrySpawn()
        {
            if(_allowedToSpawn == true)
            {
                _elapsedTime += Time.deltaTime;

                if (_elapsedTime >= _spawnStats.SecondsBetweenSpawn)
                    Spawn();
            }
        }

        private void Spawn()
        {
            Cube cube = Instantiate(_template, _contanier);
            cube.SetStats(_spawnStats.CubeStats);
            _elapsedTime = 0;
        }

        public void SetSpawnStats(CubeStats cubeStats, float secondsBetweenSpawn)
        {
            _spawnStats = new SpawnStats(cubeStats, secondsBetweenSpawn);
        }

        public void SetSpawnStats(float speed, float distance, float secondsBetweenSpawn)
        {
            _spawnStats = new SpawnStats(new CubeStats(speed, distance), secondsBetweenSpawn);
        }

        public void AllowToSpawning()
        {
            _allowedToSpawn = true;
        }
    }
}
