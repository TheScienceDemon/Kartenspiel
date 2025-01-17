using UnityEngine;

public class SoundManager : MonoBehaviour {
    public static SoundManager Singleton {  get; private set; }
    [SerializeField] AudioClip[] soundClips;

    
    private AudioSource audioSource;
    private void Awake() {
        Singleton = this;
    }

    private void Start() {
        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    
    public void PlayRandomSound() {
        if (soundClips.Length == 0) {
            Debug.LogWarning("Keine Sounds in der Liste!");
            return;
        }

        
        int randomIndex = Random.Range(0, soundClips.Length);

        
        audioSource.clip = soundClips[randomIndex];
        audioSource.Play();
    }
}
