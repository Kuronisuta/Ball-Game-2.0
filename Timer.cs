using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text mer;
    private float no;
    public GameObject ball;
    public GameObject platform;

	// Use this for initialization
	void Start () {

        ball = GameObject.FindGameObjectWithTag("Player");
        platform = GameObject.FindGameObjectWithTag("Plane");
	}

    // Update is called once per frame
    void Update()
    {


        no = Vector2.Distance(ball.transform.position, platform.transform.position);
        mer.text = "Distance: " + Mathf.RoundToInt(no);
    }
}
