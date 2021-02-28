using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private int _score;

        private UIManager _uiManager;

        private void Start()
        {
            _uiManager = FindObjectOfType<UIManager>();
        }

        public void AddScore()
        {
            _score++;
            _uiManager.UpdateScore(_score);
        }
    }
}
