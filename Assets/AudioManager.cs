using UnityEngine;

public class AudioManager : MonoBehaviour {

    [Header("References")]
    [SerializeField] private AudioSource musicSource;
    [Range(0f, 1f)][SerializeField] private float musicSourceVol;
    [SerializeField] private AudioSource footstepSource;
    [Range(0f, 1f)][SerializeField] private float footstepSourceVol;
    [SerializeField] private AudioSource soundEffectSource;
    [Range(0f, 1f)][SerializeField] private float sfxSourceVol;
    private GameManager gameManager;

    [Header("Audio Clips")]
    [SerializeField] private AudioClip levelMusic;
    [SerializeField] private AudioClip walkLoop;
    [SerializeField] private AudioClip phoneLoop;
    [SerializeField] private AudioClip taskComplete;

    void Awake() {
        musicSource.volume = musicSourceVol;
        footstepSource.volume = footstepSourceVol;
        soundEffectSource.volume = sfxSourceVol;
    }


    public enum GameSoundEffectType {
        WalkLoop, PhoneLoop, TaskComplete

    }

    // start function
    public void PlaySceneMusic() {

        musicSource.loop = true;

        musicSource.clip = levelMusic;
        musicSource.Play();

    }

    public void PlaySound(GameSoundEffectType soundType) {

        switch (soundType) {

            case GameSoundEffectType.WalkLoop:

                if (!footstepSource.isPlaying)
                    footstepSource.PlayOneShot(walkLoop);
                break;

            case GameSoundEffectType.PhoneLoop:

                if (!footstepSource.isPlaying)
                    footstepSource.PlayOneShot(phoneLoop);
                break;

            case GameSoundEffectType.TaskComplete:

                soundEffectSource.PlayOneShot(taskComplete);
                break;

            default:

                break;

        }
    }

}