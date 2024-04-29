using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic: InteractionEvent
{
    private const float defaultAnxietyAmount = 2f;
    private BackgroundAudio audio;

    public ChangeMusic(StateManager stateManager, BackgroundAudio audio, float anxietyAmount = defaultAnxietyAmount): base(stateManager, anxietyAmount)
    {
        this.audio = audio;
    }

    public override void run()
    {
        base.run();
        audio.SwitchMusic();
    }
}