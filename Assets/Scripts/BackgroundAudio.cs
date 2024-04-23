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
    private AudioClip drive;

    void Start()
    {
        //loopAudio(GetComponent<AudioSource>());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setLoopAudio(AudioSource source, AudioClip audio)
    {
        source.loop = true;
        source.clip = audio;
        source.Play();
    }

    public void stopMusic()
    {
        musicSource.Stop();
    }
}
