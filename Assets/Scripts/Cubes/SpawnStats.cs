using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cubes
{
    public struct SpawnStats
    {
        private CubeStats _cubeStats;
        private float _secondsBetweenSpawn;

        public CubeStats CubeStats => _cubeStats;

        public float SecondsBetweenSpawn => _secondsBetweenSpawn;

        public SpawnStats(CubeStats cubeStats, float secondsBetweenSpawn)
        {
            _cubeStats = cubeStats;
            _secondsBetweenSpawn = secondsBetweenSpawn;
        }
    }
}
