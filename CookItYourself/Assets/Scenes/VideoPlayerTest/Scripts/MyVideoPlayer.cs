using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class MyVideoPlayer : MonoBehaviour
{
    void Start()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = Path.Combine(Application.streamingAssetsPath, "Videos", "Test.mp4");
        videoPlayer.Play();
    }
}