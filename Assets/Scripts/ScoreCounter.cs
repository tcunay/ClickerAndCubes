using System;
using UnityEngine;

namespace Clicker
{
    public class ScoreCounter : MonoBehaviour
    {
        private int _score = 0;

        public event Action<int> ScoreChanged;

        public int Score => _score;

        public void AddScore()
        {
            _score++;
            ScoreChanged?.Invoke(_score);
        }
    }
}
