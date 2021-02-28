using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
    
        // Start is called before the first frame update
        private void Start()
        {
            scoreText.text = "0";
        }

        public void UpdateScore(int score)
        {
            scoreText.text = $"{score}";
        }
    }
}
