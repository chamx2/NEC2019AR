using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneLoader : MonoBehaviour
{

    public int sceneIndexToLoad;

    public VideoPlayer videoPlayer;


    private void Start()
    {
        videoPlayer.loopPointReached += EndReached;
    }
    public void LoadScene()
    {
        videoPlayer.loopPointReached -= EndReached;
        SceneManager.LoadScene(sceneIndexToLoad);
    }

   

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        LoadScene();
        //vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    }


}
