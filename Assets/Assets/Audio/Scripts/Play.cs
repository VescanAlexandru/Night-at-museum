using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
	public  AudioClip OtherClip;



	// Use this for initialization


	
	// Update is called once per frame
	void Update () 
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();


	}
	}

