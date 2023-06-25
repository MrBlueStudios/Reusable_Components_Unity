using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Atributes
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]
    public class AudioComponent : MonoBehaviour
    {
        [SerializeField] private AudioClip[] _audioClips;

        private AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlayAudioClip(int index)
        {
            if (_audioClips == null || _audioClips.Length == 0)
            {
                Debug.LogWarning("No audio clip assigned to AudioComponent.");
                return;
            }

            audioSource.PlayOneShot(_audioClips[index]);
        }

        public void RepeatAudioClip(int index)
        {
            if (_audioClips == null || _audioClips.Length == 0)
            {
                Debug.LogWarning("No audio clip assigned to AudioComponent.");
                return;
            }

            audioSource.clip = _audioClips[index];
            audioSource.loop = true;
            audioSource.Play();
        }

        public void GoThroughAudioClips()
        {
            if (_audioClips == null || _audioClips.Length == 0)
            {
                Debug.LogWarning("No audio clip assigned to AudioComponent.");
                return;
            }

            audioSource.loop = false;
            
            for (int i = 0; i < _audioClips.Length; i++)
            {
                audioSource.clip = _audioClips[i];
                audioSource.Play();

                while (audioSource.isPlaying)
                {
                    // Wait for the clip to finish playing
                    // we do this by using a while loop which checks if the audio is playing and if it is, it does nothing
                }
            }
        }

        public void PlayRandomAudioClip()
        {
            if (_audioClips.Length == 0)
            {
                Debug.LogWarning("No audio clips assigned to AudioComponent.");
                return;
            }

            int randomIndex = Random.Range(0, _audioClips.Length);
            AudioClip randomClip = _audioClips[randomIndex];

            audioSource.PlayOneShot(randomClip);
        }

        public void StopAudioClip()
        {
            audioSource.loop = false;
            audioSource.Stop();
        }

        public void StopLoop()
        {
            audioSource.loop = false;
        }
    }

}
