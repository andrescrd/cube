using Actors;
using Managers;
using UnityEngine;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private BoxGroup _boxGroup;
        private GameManager _gameManager;

        // Start is called before the first frame update
        private void Start()
        {
            _gameManager = FindObjectOfType<GameManager>();
            _boxGroup = FindObjectOfType<BoxGroup>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                MoveToRight();
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                _gameManager.Quit();
            }
        }

        public void MoveLeft()
        {
            _boxGroup.MoveToLeft();
        }

        public void MoveToRight()
        {
            _boxGroup.MoveToRight();
        }
    }
}