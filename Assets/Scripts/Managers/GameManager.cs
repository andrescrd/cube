using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private int _score;

        private UIManager _uiManager;
        private SoundManager _audioManager;
        private int _highest;

        private void Start()
        {
            _uiManager = FindObjectOfType<UIManager>();
            _audioManager = FindObjectOfType<SoundManager>();

            _highest = PlayerPrefs.GetInt("highest", _highest);
            _uiManager.UpdateMaxScore(_highest);
        }

        public void AddScore()
        {
            _score++;

            if (_score >= _highest)
                _highest = _score;

            _uiManager.UpdateScore(_score);
        }

        public void Play()
        {
            _audioManager.PlayClick();
            StartCoroutine(LoadRoutine());
        }

        private IEnumerator LoadRoutine()
        {
            yield return new WaitForSeconds(0.1f);
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

        public void Quit()
        {
            PlayerPrefs.SetInt("highest", _highest);
            Application.Quit();
        }
    }
}