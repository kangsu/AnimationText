using UnityEngine;
using System.Collections;

public class ProfessorWalk : MonoBehaviour {

	private Animator animator;
    private Vector2 speed = new Vector2(50, 50);
	
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		animator.SetInteger ("Direction", 1);
		if (animator) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				animator.SetInteger ("Direction", 0);
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				animator.SetInteger ("Direction", 1);
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				animator.SetInteger ("Direction",3);
			} else if (Input.GetKey (KeyCode.LeftArrow)) {
				animator.SetInteger ("Direction", 2);
			}
		}
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody2D.velocity = new Vector2(0, -10);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody2D.velocity = new Vector2(0, 10);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.velocity = new Vector2(10, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2D.velocity = new Vector2(-10, 0);
        }
    }


}
