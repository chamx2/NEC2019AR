using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoader : MonoBehaviour
{
    public float delay;
    public int sceneIndexToLoad;

    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        Debug.Log("Delay");
        yield return new WaitForSeconds(delay);
        Debug.Log("Loading Scene...");
        SceneManager.LoadScene(sceneIndexToLoad);
    }

}
