using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPillScript : MonoBehaviour
{


    AudioSource wakaSound;
    public AudioClip pacman_chomp;
    public bool alreadyPlayed = false;


	// Start is called before the first frame update
    void Start()
    {
        wakaSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(90*Time.deltaTime,0,0);
    }
	
	public static int points = 0;
    
    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Pacman")) {
			if (!alreadyPlayed) {
				points = points + 50;
				wakaSound.Play();
				alreadyPlayed = true;
			}
			Destroy(gameObject,pacman_chomp.length);
        }
    }

}
