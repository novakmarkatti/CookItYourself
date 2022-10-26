using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    [SerializeField] private string goToSceneName;

    public void OnClick()
    {
        SceneManager.LoadSceneAsync(goToSceneName);
    }
}