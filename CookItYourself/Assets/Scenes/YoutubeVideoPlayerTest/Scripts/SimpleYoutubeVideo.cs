using UnityEngine;
using UnityEngine.Video;

namespace YoutubePlayer
{
    public class SimpleYoutubeVideo : MonoBehaviour
    {
        public string videoUrl;
        private VideoPlayer videoPlayer;

        private void Start()
        {
            videoPlayer = GetComponent<VideoPlayer>();

            Play();
        }

        public async void Play()
        {
            await videoPlayer.PlayYoutubeVideoAsync(videoUrl);
            videoPlayer.Play();
        }
    }
}