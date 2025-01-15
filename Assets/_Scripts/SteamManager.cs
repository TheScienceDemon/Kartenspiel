using UnityEngine;
using Steamworks;

public class SteamManager : MonoBehaviour {
    public static SteamManager Singleton { get; private set; }
    public const uint STEAM_APP_ID = 480; // ID used for Space War (:trol:)
    const string STEAM_COLOR = "#66C0F4";

    void Awake() {
        if (Singleton == null) {
            Singleton = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    void Start() {
        try {
            SteamClient.Init(STEAM_APP_ID);
            Debug.Log($"[{nameof(SteamManager)}] Initialised <color={STEAM_COLOR}>Steam</color>!");
            Debug.Log($"[{nameof(SteamManager)}] Logged in with account \"{SteamClient.Name}\"");

            foreach (var friend in SteamFriends.GetFriends()) {
                Debug.Log($"Steam friend: {friend.Name}");
            }
        } catch (System.Exception e) {
            Debug.LogWarning($"[{nameof(SteamManager)}] Couldn't initialise <color={STEAM_COLOR}>Steam</color>: {e}");
        }
    }

    void OnApplicationQuit() {
        if (!SteamClient.IsValid) { return; }

        SteamClient.Shutdown();
        Debug.Log($"[{nameof(SteamManager)}] Shutting down...");
    }
}
