using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour {

	public GameObject model;
	public Scaler scaler;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void zoomin()
	{
		scaler.inc ();
	}

	public void zoomout()
	{
		scaler.dec ();
	}
}
