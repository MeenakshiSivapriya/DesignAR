using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	private float load;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		load += Time.deltaTime;
		if (load > 1)
			Application.LoadLevel ("Main");
	}
}
