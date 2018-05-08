using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {
	public  AudioClip OtherClip;



	// Use this for initialization



	// Update is called once per frame
	void Update () 
	{}


	public void Stop1()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Stop();
	}	
}
