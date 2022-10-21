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

            Load();
            Play();
        }

        public async void Load()
        {
            await videoPlayer.PlayYoutubeVideoAsync(videoUrl);
        }
        public void Play()
        {
            videoPlayer.Play();
        }
    }
}