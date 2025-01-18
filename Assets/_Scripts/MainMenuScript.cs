using Mirror;
using UnityEngine;

public class MainMenuScript : MenuBase {
    //[Header(nameof(MainMenuScript))]
    // To be added

    // Overrides

    public override void OpenSubmenu(int newSubmenu) {
        switch (newSubmenu) {
            case (int) SubmenuType.None:
                CloseAnySubmenu();
                PlayClickSound();
                break;
            case (int) SubmenuType.Settings:
                CloseAnySubmenu();
                submenuObjs[newSubmenu].SetActive(true);
                PlayClickSound();
                break;
            default:
                break;
        }
    }

    // Main Menu

    public void HostGame() {
        NetworkManager.singleton.StartHost();
    }

    public void Quit() {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


    // Other

    new enum SubmenuType {
        Settings,
        None = -1
    }
}
