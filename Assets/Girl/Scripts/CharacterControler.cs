using UnityEngine;
using System.Collections;

public class CharacterControler : MonoBehaviour {

    public Animator animator;
    public float walkSpeed = 2;
    public float turnSpeed = 2;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float moveForward = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
        float moveRotate = Input.GetAxis("Horizontal") * turnSpeed;

        // Move the player
        transform.Translate( Vector3.forward * moveForward );
        transform.Rotate( Vector3.up * moveRotate );

        if (Input.GetKeyDown(KeyCode.W)) {
            animator.SetBool( "walk", true );
        }
        if(Input.GetKeyUp(KeyCode.W)) {
            animator.SetBool( "walk", false );
        }   
	}
}
