using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody2D.velocity = new Vector2(speed.x * direction.x, speed.y * direction.y);
	}
}
