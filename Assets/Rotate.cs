using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	void Start () {
	}

	void Update () {
		var v = new Vector3(Time.time, 0, Time.time / 3.0f);
		transform.Rotate(v);
	}

}
