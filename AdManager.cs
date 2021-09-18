using UnityEngine;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif
public class AdManager : MonoBehaviour
{

    public static AdManager Instance { get; private set; }
    private bool m_awaitingCallBack = false;
    private string m_callbackVideoid;
    private void Awake()
    {
        Instance = this;

    }
    public void MostarAnuncio(string videoID, bool enableCallback)

    {
#if UNITY_ADS
        if (!Advertisement.IsReady(videoID))
        {
            Debug.LogWarning("No está disponible para cargar " + videoID);
        }
        else
        {
            ShowOptions options = new ShowOptions();
            if (enableCallback)
            {
                if (m_awaitingCallBack)
                    return;
                m_callbackVideoid = videoID;
                m_awaitingCallBack = true;
                options.resultCallback = OnAdd_Result;
            }
            Advertisement.Show(videoID, options);
        }
#endif
    }

    private void OnAdd_Result(ShowResult resultados)
    {
        m_awaitingCallBack = false;
        print(m_callbackVideoid);
        switch (resultados)
        {
            case ShowResult.Finished:
                Debug.Log("El video a finalizado completo");
                break;
            case ShowResult.Skipped:
                Debug.Log("El usuario no vio el video");
                break;
            case ShowResult.Failed:
                break;
                Debug.Log("Error en el video");
        }
    }

}
