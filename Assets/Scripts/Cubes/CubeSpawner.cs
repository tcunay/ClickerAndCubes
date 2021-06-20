using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cubes
{
    public class CubeSpawner : MonoBehaviour
    {
        [SerializeField] private Cube _template;

        private SpawnStats _spawnStats;
        private float _elapsedTime;

        private void Update()
        {
            TrySpawn();
        }

        private void TrySpawn()
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime >= _spawnStats.SecondsBetweenSpawn)
                Spawn();
        }

        private void Spawn()
        {
            Cube cube = Instantiate(_template);
            cube.SetStats(_spawnStats.CubeStats);
            _elapsedTime = 0;
        }

        public void SetSpawnStats(CubeStats cubeStats, float secondsBetweenSpawn)
        {
            _spawnStats = new SpawnStats(cubeStats, secondsBetweenSpawn);
        }
    }
}
