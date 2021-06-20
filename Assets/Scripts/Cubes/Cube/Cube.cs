using UnityEngine;

namespace Cubes
{
    public class Cube : MonoBehaviour
    {
        private CubeStats _stats;

        public CubeStats Stats => _stats;

        public void SetStats(CubeStats stats)
        {
            _stats = stats;
        }
    }
}
