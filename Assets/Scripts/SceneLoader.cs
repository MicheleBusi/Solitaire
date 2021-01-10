using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] EC_SceneManagement eventChannel = default;

    private void OnEnable()
    {
        eventChannel.OnSceneLoadRequested += LoadScene;
        eventChannel.OnSceneUnloadRequested += UnloadScene;
    }

    private void OnDisable()
    {
        eventChannel.OnSceneLoadRequested -= LoadScene;
        eventChannel.OnSceneUnloadRequested -= UnloadScene;
    }

    public void LoadScene(string sceneName)
    {
        float delay = 0.5f;
        StartCoroutine(LoadSceneAsyncAndSetActive(sceneName, delay));
    }

    IEnumerator LoadSceneAsyncAndSetActive(string sceneName, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);

        yield return SceneManager.LoadSceneAsync(
            sceneName, 
            LoadSceneMode.Additive);

        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        eventChannel.OnSceneLoadCompleted.Invoke(sceneName);
    }

    public void UnloadScene(string sceneName)
    {
        float delay = 0.5f;
        StartCoroutine(UnloadSceneWithDelay(sceneName, delay));
    }

    IEnumerator UnloadSceneWithDelay(string sceneName, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);

        SceneManager.UnloadSceneAsync(sceneName);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}

