using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBGM : MonoBehaviour
{
    //[SerializeField] private AudioSource temp;
    [SerializeField] private AudioClip _clip;
    //for music.
    void Start()
    {
        MusicSound2.instance2.Playsound2(_clip, MusicSound.volToggler);
        //Playsound(_clip, MusicSound.volToggler);
        
    }

}
