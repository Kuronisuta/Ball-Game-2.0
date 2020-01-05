using UnityEngine;
using System.Collections;

public class Spewn : MonoBehaviour {

	float ret = 6f;
	float rut = 10f;
    private object targetObj;
    public float counter = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
	 void OnCollisionEnter (Collision col) {

        counter += 1f; 

		 if(col.gameObject.name == "Player")
	 {
		 NewPosition();
		 if(ret <= 18)
		 ret *= 3f;
	 }
	 	if(ret>=10){
			 
			 rut *= 1f;
            
        }
	 }
	 void NewPosition(){
		  Vector3 temp = transform.position;
		  temp.y += Random.Range(-8f,-10f);
		  temp.x += Random.Range(-10f, 10f);
		  temp.z += Random.Range(ret, rut);
		  transform.position = temp;
		  
		  Vector3 tump = transform.localScale;
		  tump.x = Random.Range(.25f, .85f);
		  tump.z = Random.Range(.25f,.85f);
		  tump.y = .65f;
		  transform.localScale = tump;
	 }
	 
}
