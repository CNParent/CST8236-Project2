using UnityEngine;
using System.Collections;

public class TextureSwitch : MonoBehaviour {

    public Vector3 rotationMatrix;
    public Material[] materials;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
        Debug.Log("Materials count: " + materials.Length);
    }

	void Update () 
    {
        gameObject.transform.Rotate(rotationMatrix * Time.deltaTime);
        if(Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
            else if (Input.GetKeyDown(KeyCode.Alpha2)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[1];
            else if (Input.GetKeyDown(KeyCode.Alpha3)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[2];
            else if (Input.GetKeyDown(KeyCode.Alpha4)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[3];
            else if (Input.GetKeyDown(KeyCode.Alpha5)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[4];
            else if (Input.GetKeyDown(KeyCode.Alpha6)) gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[5];
        }
	}
}
