using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    private enum AudioGroup
    {
        Master,
        Music,
        Ambience,
        SFX
    }
    [SerializeField] private AudioGroup audioGroup;

    private Slider volumeSlider;

    private void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
        ChangeVolume(volumeSlider.value);
    }

    public void ChangeVolume(float volume)
    {
        if (volume <= 0)
        {
            audioMixer.SetFloat(audioGroup + "Volume", -80);
            return;
        }
        // set volume of audio group 0 is -60 and 1 is 20
        float volumeInDecibels = Mathf.Lerp(-40, 20, volume);
        audioMixer.SetFloat(audioGroup + "Volume", volumeInDecibels);
    }
}
