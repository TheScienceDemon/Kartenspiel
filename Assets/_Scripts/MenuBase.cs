using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class MenuBase : MonoBehaviour {
    [SerializeField] protected AudioClip clickSound;
    [SerializeField] protected AudioClip denySound;
    [SerializeField] protected GameObject[] submenuObjs;

    protected AudioSource source;
    protected bool anySubmenuOpen;

    // To be added later:
    // protected Mirror.NetworkManager networkManager;

    void Awake() {
        // networkManager = FindObjectOfType<Mirror.NetworkManager>();
        source = GetComponent<AudioSource>();
    }

    // Method should roughly look like this
    public virtual void OpenSubmenu(int newSubmenu) {/*
        switch (newSubmenu) {
            case (int) SubmenuType.None:
                CloseAnySubmenu();
                PlayClickSound();
                break;
            case (int) SubmenuType.XXX:
                if (anySubmenuOpen) { CloseAnySubmenu(); }
                submenuObjs[newSubmenu].SetActive(true);
                PlayClickSound();
                anySubmenuOpen = true;
                break;
            default:
                break;
        }*/
    }

    protected void CloseAnySubmenu() {
        foreach (GameObject submenu in submenuObjs) {
            submenu.SetActive(false);
        }

        anySubmenuOpen = false;
    }

    protected void PlayClickSound() {
        source.PlayOneShot(clickSound);
    }

    protected void PlayDenySound() {
        source.PlayOneShot(denySound);
    }

    protected enum SubmenuType {
        None = -1
    }
}
