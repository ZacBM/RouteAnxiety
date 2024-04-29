using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class BackgroundAudio
{
    private AudioSource musicSource;
    private AudioSource drivingSource;
    private List<AudioClip> tracks;
    private float staticVolume = 1f;
    private System.Random random = new System.Random();
    private int index;
    private float musicVolume;

    public BackgroundAudio(AudioSource musicSource, AudioSource drivingSource, List<AudioClip> tracks, float staticVolume)
    {
        this.musicSource = musicSource;
        this.drivingSource = drivingSource;
        this.tracks = tracks;
        this.staticVolume = staticVolume;
    }

    public void Start()
    {
        index = random.Next(2, tracks.Count);
        SetLoopAudio(musicSource, tracks[index]);
        SetLoopAudio(drivingSource, tracks[1]);
        musicVolume = musicSource.volume;
    }

    public void SetLoopAudio(AudioSource source, AudioClip audio)
    {
        source.loop = true;
        source.clip = audio;
        source.Play();
    }

    public async void SwitchMusic()
    {
        int newSong = random.Next(2, tracks.Count);
        while (newSong == index)
        {
            newSong = random.Next(2, tracks.Count);
        }
        index = newSong;

        musicSource.volume = staticVolume;
        musicSource.loop = false;
        musicSource.clip = tracks[0];
        musicSource.Play();
        await Task.Delay((int)(musicSource.clip.length * 1000));
        if (musicSource != null)
        {
            PlayNextTrack();
        }
    }

    public void PlayNextTrack()
    {
        musicSource.volume = musicVolume;
        musicSource.loop = true;
        musicSource.clip = tracks[index];
        musicSource.Play();
    }
}