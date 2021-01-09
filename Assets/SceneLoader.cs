using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneWithDelay(string sceneName, float delay)
    {
        StartCoroutine(LoadSceneAsyncAndSetActive(sceneName, delay));
    }


    IEnumerator LoadSceneAsyncAndSetActive(string sceneName, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);

        yield return SceneManager.LoadSceneAsync(
            sceneName, 
            LoadSceneMode.Additive);

        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
    }
}

