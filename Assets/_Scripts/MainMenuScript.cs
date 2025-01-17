using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.VirtualTexturing;
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

    private void Update() {
        if (!Input.GetKeyDown(KeyCode.Mouse0)) { return; }

        SoundManager.Singleton.PlayRandomSound();
    }

    public void EndGame() {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
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
        } else {
            overallSettingsObj.SetActive(true);
        }
    }
    public void LoadScene() {
        SceneManager.LoadScene(2);
    }
}
