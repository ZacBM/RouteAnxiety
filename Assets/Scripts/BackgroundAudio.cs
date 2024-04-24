using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource musicSource;
    [SerializeField]
    private AudioSource drivingSource;
    [SerializeField]
    private AudioClip music;
    [SerializeField]
    private AudioClip music2;
    [SerializeField]
    private AudioClip drive;
    [SerializeField]
    private int seconds;
    private int i;
    void Start()
    {
        setLoopAudio(musicSource, music);
        setLoopAudio(drivingSource, drive);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (i / 60 == seconds)
        {
            switchMusic(music2);
        }
    }
    public void setLoopAudio(AudioSource source, AudioClip audio)
    {
        source.loop = true;
        source.clip = audio;
        source.Play();
    }

    public void switchMusic(AudioClip audio)
    {

        musicSource.loop = true;
        musicSource.clip = audio;
        musicSource.Play();
    }
}
