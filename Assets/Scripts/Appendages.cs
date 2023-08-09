using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appendages : MonoBehaviour
{
    private Vector3 MoveInput = Vector3.zero;
    private Vector3 RotateInput = Vector3.zero;
    [SerializeField] private float speed = 1;
    [SerializeField] private bool forward = true;
    // Start is called before the first frame update
    void Awake() { }
    // Start is called before the first frame update
    void Start() { }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log(RotateInput.x);
            if (transform.rotation.x > 0.2f)
                forward = false;
            if (transform.rotation.x < -0.2f)
                forward = true;
            if (forward)
                RotateInput.x = 180f / 3.1415f * speed * Time.deltaTime;
            else
                RotateInput.x = -180f / 3.1415f * speed * Time.deltaTime;
            transform.Rotate(RotateInput);
        }
    }
}
