using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    private Transform tr;

    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start() {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            tr.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            tr.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            tr.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            tr.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.Space)) {
            tr.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);
        }
    }
}
