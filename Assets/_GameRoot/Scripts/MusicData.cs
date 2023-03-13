using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MusicData
{
    public int BPM;
    public AudioClip audioClip;
    public bool isThatRandom;
    public Transform[] checkpointPositions;
}
