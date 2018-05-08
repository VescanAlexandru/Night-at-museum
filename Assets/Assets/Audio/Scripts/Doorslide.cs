using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorslide : MonoBehaviour {

	public GameObject slide;

	public void OnClick()
	{
		iTween.MoveBy(gameObject, iTween.Hash("z", 4, "easeType", "easeInOutExpo", 0, "pingPong", "delay",0, "speed",0.9));
	}		
}