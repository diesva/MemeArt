
using UnityEngine;

public class LoadManager : MonoBehaviour
{

    public void verVideoSkip()
    {
        AdManager.Instance.MostarAnuncio("video", false);

    }
    public void verVideoNoSkip()
    {
        AdManager.Instance.MostarAnuncio("rewardedvideo", true);

    }
}
