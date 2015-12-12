using UnityEngine;
using System.Collections;

public class RotationZero : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		transform.localPosition = Vector3.zero; 
		transform.eulerAngles = new Vector3(0f, 180.0f, 0f);
	}
}
