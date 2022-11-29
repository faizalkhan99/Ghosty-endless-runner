using UnityEngine;


public class MusicSound : MonoBehaviour
{
    public static int volToggler = 1;
    public static MusicSound instance;
[SerializeField] private AudioSource _effectSource;
    

void Awake()
{
    if (instance == null)
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }
        AudioListener.volume = volToggler;
}

    public void Playsound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip, 5f);
    }
    public void ChangeMasterVol()
    {
        if (volToggler == 1) volToggler = 0;
        else if(volToggler == 0) volToggler = 1;    
    }
    public void Update()
    {
        AudioListener.volume = volToggler;
    }
}