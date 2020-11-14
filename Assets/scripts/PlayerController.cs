using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    static Animator anim;
    private float speed = 8.0f;
    private float rotationSpeed = 100f;

    

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        
        if (translation != 0) {

            anim.SetBool("isWalking", true);
            

        } else {

            anim.SetBool("isWalking", false);
            

        }
		
	}

    private void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.tag == ("Enemy")) {

            SceneManager.LoadScene("end-game");
        }
    }
}
