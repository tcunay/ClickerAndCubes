using TMPro;
using UnityEngine;

namespace Clicker
{
    [RequireComponent(typeof(TMP_Text))]
    public class ScoreShowing : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _scoreCounter;

        private TMP_Text _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            ShowScore(_scoreCounter.Score);

            _scoreCounter.ScoreChanged += ShowScore;
        }
        private void OnDisable()
        {
            _scoreCounter.ScoreChanged -= ShowScore;
        }

        private void ShowScore(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}
