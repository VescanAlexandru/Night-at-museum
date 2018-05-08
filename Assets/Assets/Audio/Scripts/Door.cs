using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public GameObject door;

	public void Onclick () {
		
		iTween.RotateBy(gameObject, iTween.Hash("y", -0.2, "easeType",4, "easeInOutBack", "loopType", "pingPong", "delay"));
		
	}

}