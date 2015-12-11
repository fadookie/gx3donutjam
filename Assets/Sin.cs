using UnityEngine;
using System.Collections;

public class Sin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(Mathf.Sin (Time.time), 0, Mathf.Cos(Time.time*2));
	
	}
}
