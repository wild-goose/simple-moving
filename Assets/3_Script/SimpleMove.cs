using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 2.0f;

    public Animator car;    

    // Start is called before the first frame update
    void Start() {
        if (car == null) {
            car = gameObject.GetComponentInChildren<Animator>();
        }
        car.speed = 2.0f;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) {
            float verticalPosition = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            float horizontalPosition = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            transform.position += new Vector3(-1 * horizontalPosition, 0, -1 * verticalPosition);
            transform.forward = new Vector3(-1 * horizontalPosition, 0, -1 * verticalPosition);

            if (car != null) {
                car.SetBool("isRun", true);
            }
        } else {
            if (car != null) {
                car.SetBool("isRun", false);
            }
        }
    }
}
