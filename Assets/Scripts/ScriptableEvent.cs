using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

[CreateAssetMenu(fileName = "InteractionEvent", menuName = "GAME OBJECTS/Interaction Event", order = 1)]
public class ScriptableEvent : ScriptableObject
{
    public float anxietyIncrease;
    public System.Object interactionEvent;
}