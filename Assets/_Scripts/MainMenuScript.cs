using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour {

    [SerializeField] SoundManager soundManager;
    [SerializeField] GameObject mainMenuObj;
        [SerializeField] GameObject singlePlayerObj;
        [SerializeField] GameObject multiPlayerObj;
        [SerializeField] GameObject endGameObj;
        [SerializeField] GameObject settingsMenuObj;
            [SerializeField] GameObject audioSettingsObj;
            [SerializeField] GameObject overallSettingsObj;
            [SerializeField] GameObject videoSettingsObj;
            [SerializeField] GameObject keybindsSettingsObj;



    void Start() {
        mainMenuObj.SetActive(true);
    }

    public void OpenSettingsMenu() {
        if (settingsMenuObj.activeSelf) {
            settingsMenuObj.SetActive(false);
            mainMenuObj.SetActive(true);
            soundManager.PlayRandomSound();
        } else {
            mainMenuObj.SetActive(false);
            settingsMenuObj.SetActive(true);
            soundManager.PlayRandomSound();
        }
    }
    
    public void OpenOverallSettings() {
        if (overallSettingsObj.activeSelf) {
            overallSettingsObj.SetActive(false);
            soundManager.PlayRandomSound();
        } else {
            overallSettingsObj.SetActive(true);
            soundManager.PlayRandomSound();
        }
    }
    public void LoadScene() {
        SceneManager.LoadScene(2);
    }
}
