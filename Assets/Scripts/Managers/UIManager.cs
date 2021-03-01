using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    [RequireComponent(typeof(Text))]
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private Text maxScore;
    
        // Start is called before the first frame update
        private void Start()
        {
            scoreText.text = "0";
        }

        public void UpdateScore(int score)
        {
            scoreText.text = $"{score}";
        }  
        
        public void UpdateMaxScore(int score)
        {
            maxScore.text = $"{score}";
        }
    }
}
