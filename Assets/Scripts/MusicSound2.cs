using UnityEngine;


public class MusicSound2 : MonoBehaviour
{
    public static int volToggler2;
    public static MusicSound2 instance2;
    [SerializeField] private AudioSource _effectSource;
    

void Awake()
{
    if (instance2 == null)
    {
        instance2 = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }

}

    public void Playsound2(AudioClip clip, int num)
    {
        _effectSource.PlayOneShot(clip, num);
    }
    
    public void Update()
    {
        volToggler2 = MusicSound.volToggler;
        AudioListener.volume = volToggler2;
    }
}