using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    [RequireComponent(typeof(Button))]
    public class ClickHandler : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _scoreCounter;

        private Button _clickButton;

        private void Awake()
        {
            _clickButton = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _clickButton.onClick.AddListener(OnButtonClick);
        }

        private void OnDisable()
        {
            _clickButton.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            _scoreCounter.AddScore();
        }
    }
}
