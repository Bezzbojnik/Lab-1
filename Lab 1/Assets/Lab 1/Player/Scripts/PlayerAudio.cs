using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        PlayerController.OnShoot += PlayAudioShoot;
    }

    private void PlayAudioShoot()
    {
        _audioSource.Play();
    }

    private void OnDestroy()
    {
        PlayerController.OnShoot -= PlayAudioShoot;
    }
}
