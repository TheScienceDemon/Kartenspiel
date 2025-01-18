using UnityEngine;

public class SettingsMenuScript : MenuBase {
    public override void OpenSubmenu(int newSubmenu) {
        switch (newSubmenu) {
            case (int) SubmenuType.None:
                CloseAnySubmenu();
                PlayClickSound();
                break;
            case (int) SubmenuType.Graphics:
            case (int) SubmenuType.Audio:
            case (int) SubmenuType.Controls:
            case (int) SubmenuType.Other:
                CloseAnySubmenu();
                submenuObjs[newSubmenu].SetActive(true);
                PlayClickSound();
                break;
            default:
                break;
        }
    }

    new enum SubmenuType {
        None = -1,
        Graphics,
        Audio,
        Controls,
        Other
    }
}
