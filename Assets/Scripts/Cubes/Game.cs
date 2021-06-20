using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Cubes
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private CubeSpawner _spawner;
        [SerializeField] private TMP_InputField _speedValue;
        [SerializeField] private TMP_InputField _distanceValue;
        [SerializeField] private TMP_InputField _secondsBetweenSpawnValue;

        private void OnEnable()
        {
            _startButton.onClick.AddListener(StartGame);
        }

        private void OnDisable()
        {
            _startButton.onClick.RemoveListener(StartGame);
        }

        private void StartGame()
        {
           if(float.TryParse(_speedValue.text, out float speed) 
                && float.TryParse(_distanceValue.text, out float distance) 
                && float.TryParse(_secondsBetweenSpawnValue.text, out float secondsBetweenSpawn))
            {
                _spawner.SetSpawnStats(speed, distance, secondsBetweenSpawn);
                _spawner.AllowToSpawning();
            }
        }
    }
}
