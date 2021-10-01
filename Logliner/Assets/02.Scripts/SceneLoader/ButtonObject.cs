using UnityEngine;

public class ButtonObject : MonoBehaviour
{
    public string _sceneName = "SettingXR4";
    public void LoadGame()
    {
        SceneLoader.Instance.LoadNewScene(_sceneName);
    }
}
