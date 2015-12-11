using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	void Update () {
		var v = new Vector3(Input.mousePosition.x*3.0f, Input.mousePosition.y*3.0f);
		v.z = Camera.main.nearClipPlane;
		var pt = Camera.main.ScreenToWorldPoint(v);
		pt = pt * 20.0f;
		transform.LookAt (-pt);
	}
}
