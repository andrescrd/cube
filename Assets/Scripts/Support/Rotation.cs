using UnityEngine;

namespace Support
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float speed = 1;

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(transform.position, Vector3.up,speed * Time.deltaTime);
        }
    }
}
