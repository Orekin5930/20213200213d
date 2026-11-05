using UnityEngine;
using UnityEngine.Video;

public class PlayOnVisible : MonoBehaviour
{
    // 유니티 인스펙터 창에서 직접 끌어다 넣을 수 있도록 public으로 선언합니다.
    public VideoPlayer videoPlayer;

    void OnEnable()
    {
        if (videoPlayer != null)
        {
            // 유니티 VideoPlayer의 이어보기 버그를 차단하는 가장 확실한 초기화 순서
            videoPlayer.Stop();
            videoPlayer.time = 0;
            videoPlayer.frame = 0;
            videoPlayer.Play();
        }
    }

    void OnDisable()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
        }
    }
}