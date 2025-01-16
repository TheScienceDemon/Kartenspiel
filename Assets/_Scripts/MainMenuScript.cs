using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
    [SerializeField] GameObject settingsMenuObj;
    [SerializeField] GameObject mainMenuObj;
    [SerializeField] GameObject overallSettingsObj;

    void Start() {
        mainMenuObj.SetActive(true);
    }
    public void OpenSettingsMenu() {
        if (settingsMenuObj.activeSelf) {
            settingsMenuObj.SetActive(false);
            mainMenuObj.SetActive(true);
        } else {
            mainMenuObj.SetActive(false);
            settingsMenuObj.SetActive(true);
        }
    }
    public void OpenOverallSettings() {
        if (overallSettingsObj.activeSelf) {
            overallSettingsObj.SetActive(false);
            settingsMenuObj.SetActive(true);
        } else {
            overallSettingsObj.SetActive(true);
            settingsMenuObj.SetActive(false);
        }
    }
    public void LoadScene() {
        SceneManager.LoadScene(2);
    }
}
