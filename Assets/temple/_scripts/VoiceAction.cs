﻿using UnityEngine;
using System.Collections;

public class VoiceAction : ScriptAction {

    public GameObject actor;
    public AudioClip clip;

    private AudioSource audioSource;

	// Use this for initialization
	public override void Start () {
        audioSource = actor.GetComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
    }
	
	// Update is called once per frame
	public override void UpdateAction() {
        if (!audioSource.isPlaying) complete();
    }

    public override void Instant()
    {
        if (audioSource != null) audioSource.Stop();
    }

}
