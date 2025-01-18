using Mirror;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour {

    public void QuitLobby() {
        NetworkManager.singleton.StopHost();
    }

    public void StartGame() {
        NetworkManager.singleton.ServerChangeScene("SampleScene");
    }
}
