using UnityEngine;
using System.Collections;

public class ProfessorWalk : MonoBehaviour {

	private Animator animator;
	
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


}
