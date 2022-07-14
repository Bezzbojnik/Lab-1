using UnityEngine;

public class EnemyAudio : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioDestroy()
    {
        _audioSource.Play();
    }
}
