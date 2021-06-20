using UnityEngine;

namespace Cubes
{
    public class Cube : MonoBehaviour
    {
        private CubeStats _stats;

        public void SetStats(CubeStats stats)
        {
            _stats = stats;
        }
    }
}
