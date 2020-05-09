using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testgatescript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject triggertest;
    public GameObject leftcube;
    public GameObject rightcube;

    Animator leftAnim;
    Animator rightAnim;

    void Start()
    {
        leftAnim = leftcube.GetComponent <Animator >();
        rightAnim = rightcube.GetComponent <Animator >();        
    }

	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.tag == "Enemy") {
			SlideDoors(true);
		}
	}

	void OnTriggerExit(Collider coll) {
		if (coll.gameObject.tag == "Enemy") {
			SlideDoors(false);
		}
	}

	void SlideDoors(bool state) {
    	leftAnim.SetBool("slide", state);
    	rightAnim.SetBool("slide", state);
	}

}
