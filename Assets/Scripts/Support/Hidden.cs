using System.Collections;
using UnityEngine;

namespace Support
{
    public class Hidden : MonoBehaviour
    {
        [SerializeField] private float time = 5;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(HiddeRoutine());
        }

        IEnumerator HiddeRoutine()
        {
            yield return new WaitForSeconds(time);
            transform.gameObject.SetActive(false);
        }
    }
}
