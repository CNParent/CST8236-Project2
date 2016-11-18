using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	void Update () {
	    if(Input.anyKeyDown && Input.GetKeyDown(KeyCode.Space))
        {
            var camera = GetComponent<Camera>();
            camera.orthographic = !camera.orthographic;
        }
	}
}
