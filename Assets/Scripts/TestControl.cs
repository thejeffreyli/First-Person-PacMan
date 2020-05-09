using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestControl : MonoBehaviour {


    // public float MovementSpeed = 10f;

    public AudioSource deathSound;
    public bool alreadyPlayed = false;
    float timeToLoadScene = 3;
    private Animator animator = null; 

    // private Vector3 up = new Vector3(0, 0, 0),
    //  right = new Vector3(0, 90, 0),
    //  down = new Vector3(0, 180, 0),
    //  left = new Vector3(0, 270, 0),
    //  currentDirection = new Vector3(0, 0, 0);

    private Vector3 initialPosition = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    // public void Reset() {
    //     transform.position = initialPosition;
    //     animator.SetBool("isDead", false);
    //     animator.SetBool("isMoving", false);
    //     // currentDirection = down;
    // }

    void Start() {
        QualitySettings.vSyncCount = 0;

        initialPosition = transform.position;
        animator = GetComponent<Animator>();

        deathSound = GetComponent<AudioSource>();

        // Reset();
    }

    // Update is called once per frame
    void Update() {
        var isMoving = true;

        var isDead = animator.GetBool("isDead");

        if (isDead) {
            isMoving = false;
        } 

  //       else if (Input.GetKey(KeyCode.UpArrow)) {
  //        currentDirection = up;
  //       } else if (Input.GetKey(KeyCode.RightArrow)) {
  //        currentDirection = right;
  //       } else if (Input.GetKey(KeyCode.DownArrow)) {
  //        currentDirection = down;
  //       } else if (Input.GetKey(KeyCode.LeftArrow)) {
  //        currentDirection = left;
  //       } else isMoving = false;

        // transform.localEulerAngles = currentDirection; 
        animator.SetBool("isMoving", isMoving);

  //       if (isMoving) {
  //        transform.Translate(Vector3.forward*MovementSpeed*Time.deltaTime);
  //       }

    }
    

   void GoToScene(){
    SceneManager.LoadScene("GameOver");
   }


    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
          if (!alreadyPlayed)
          {
              deathSound.Play();
              alreadyPlayed = true;
          }
          animator.SetBool("isDead", true);
          // SceneManager.LoadScene("GameOver");
          Invoke("GoToScene", timeToLoadScene);
        }
        
    }



}
