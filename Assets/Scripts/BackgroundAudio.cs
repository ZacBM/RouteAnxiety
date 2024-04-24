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
    private List<AudioClip> tracks;
    private System.Random random = new System.Random();
    private int index;
    private int i;
    private float musicVolume;

    void Start()
    {
        index = random.Next(2, tracks.Count);
        setLoopAudio(musicSource, tracks[index]);
        setLoopAudio(drivingSource, tracks[1]);
        musicVolume = .2f;
        musicSource.volume = musicVolume;
        drivingSource.volume = .75f;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (i / 60 == 7)
        {
            switchMusic();
            i = 0;
        }
    }

    public void setLoopAudio(AudioSource source, AudioClip audio)
    {
        source.loop = true;
        source.clip = audio;
        source.Play();
    }

    public void switchMusic()
    {
        int newSong = random.Next(2, tracks.Count);
        while (newSong == index)
        {
            newSong = random.Next(2, tracks.Count);
        }
        index = newSong;

        musicSource.volume = 1f;
        musicSource.loop = false;
        musicSource.clip = tracks[0];
        musicSource.Play();

        StartCoroutine(PlayNextTrack());
    }

    IEnumerator PlayNextTrack()
    {
        yield return new WaitForSeconds(musicSource.clip.length);
        musicSource.volume = musicVolume;
        musicSource.loop = true;
        musicSource.clip = tracks[index];
        musicSource.Play();
    }
}