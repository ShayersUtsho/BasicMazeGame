using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appendages : MonoBehaviour
{
    private Vector3 MoveInput = Vector3.zero;
    private Vector3 RotateInput = Vector3.zero;
    [SerializeField] private float offset = 1f;
    [SerializeField] private float speed = 1;
    // Start is called before the first frame update
    void Awake() { }
    // Start is called before the first frame update
    void Start() { }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            RotateInput.x = Mathf.Sin(offset + 1) / 10;
            transform.Rotate(RotateInput);
            offset += 0.01f * speed;
        }
    }
}
