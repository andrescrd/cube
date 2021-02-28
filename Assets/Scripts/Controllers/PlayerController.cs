using Actors;
using UnityEngine;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private BoxGroup _boxGroup;

        // Start is called before the first frame update
        private void Start()
        {
            _boxGroup = FindObjectOfType<BoxGroup>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _boxGroup.MoveToLeft();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _boxGroup.MoveToRight();
            }
        }
    }
}