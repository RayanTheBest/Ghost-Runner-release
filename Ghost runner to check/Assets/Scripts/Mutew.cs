using UnityEngine;
using UnityEngine.UI;

public class Mutew : MonoBehaviour
{
    
    bool muted;
    [SerializeField]
    Text mutetext = null;

    private bool isMuted;

    private void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
    }

    public void mute()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    }

    void Update()
    {

        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "Muted";

        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Unmuted";

        }
    }

    public void Mute()
    {
        muted = !muted;

    }
}
