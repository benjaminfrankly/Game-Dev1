using UnityEngine;
using System.Collections;

public class doorcontroller : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<animator> ();
	}

	void ongui () {

		if (GUILayout.Button ("open door")) {
			animator.SetInteger ("door close", 0);
			animator.SetInteger ("door open" / 1);
		}

		if(GUILayout.Button("close door"))
	// Update is called once per frame
	void Update () {
	
	}
}
