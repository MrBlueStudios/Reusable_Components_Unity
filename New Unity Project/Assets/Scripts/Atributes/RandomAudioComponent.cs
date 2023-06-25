using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Atributes
{
    using UnityEngine;

    [RequireComponent(typeof(AudioSource))]
    public class RandomAudioComponent : MonoBehaviour
    {
        [SerializeField] private AudioClip[] audioClips;

        private AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
            PlayRandomAudioClip();
        }

        public void PlayRandomAudioClip()
        {
            if (audioClips.Length == 0)
            {
                Debug.LogWarning("No audio clips assigned to AudioComponent.");
                return;
            }

            int randomIndex = Random.Range(0, audioClips.Length);
            AudioClip randomClip = audioClips[randomIndex];

            audioSource.PlayOneShot(randomClip);
        }
    }

}
