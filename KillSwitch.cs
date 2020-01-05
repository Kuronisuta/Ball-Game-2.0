using UnityEngine;
using System.Collections;


public class KillSwitch : MonoBehaviour
{
	public GameObject plane1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	transform.position = new Vector3(-20f, plane1.transform.position.y - 20f,-20f);
	
	}
	void OnCollisionEnter (Collision col){
		
		if (col.gameObject.name == "Player")
		{
		
		}
		
	}
}
