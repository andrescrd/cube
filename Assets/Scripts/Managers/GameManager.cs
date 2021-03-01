using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private int _score;

        private UIManager _uiManager;
        private SoundManager _auiManager;

        private void Start()
        {
            _uiManager = FindObjectOfType<UIManager>();
            _auiManager = FindObjectOfType<SoundManager>();
        }

        public void AddScore()
        {
            _score++;
            _uiManager.UpdateScore(_score);
        }

        public void Play()
        {
            _auiManager.PlayClick();
            StartCoroutine(LoadRoutine());
        }

        private IEnumerator LoadRoutine()
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
