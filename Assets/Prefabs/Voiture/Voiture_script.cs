using UnityEngine;
using System.Collections;

public class Voiture_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{			
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
		
		Vector3 relativePos = worldPos - this.transform.position;
		
		Debug.Log("WORLD: " + worldPos.ToString());
		Debug.Log("RELATIVE:" + relativePos.ToString());
		relativePos.z = 0.0f;
		relativePos = relativePos.normalized;

		if(Input.GetMouseButton(0))
		{
			Debug.DrawLine(transform.position, transform.position + relativePos);
		}	
	}
}
