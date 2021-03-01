using UnityEngine;

namespace Managers
{
    public class SoundManager : MonoBehaviour
    {

        [SerializeField] private AudioClip clickClip;
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlayClick()
        {
            _audioSource.clip = clickClip;
            _audioSource.Play();
        }
    }
}
