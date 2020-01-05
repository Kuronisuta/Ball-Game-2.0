using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
	private float timed;
	
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {
		timed += (Mathf.Clamp(Time.deltaTime, 100.0f, 100.0f)/ 100);

        float moveHorizontal = 1.3f * Input.GetAxis("Horizontal");
        float moveVertical = 1.3f * Input.GetAxis("Vertical");
		
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
		
		if ( timed >= 100)
		{
			speed += .05f;
		}
	}

    
    void OnCollisionEnter (Collision col)
    {

        if (col.gameObject.name == "killZone")
        {
            Application.LoadLevel("game");
        }
    }

}