using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotateSpeed = 25;
    [SerializeField] private float jumpHeight = 10f;
    private float i = 10f;
    void Update()
    {
        movePlayer(KeyCode.UpArrow, KeyCode.W, Vector3.forward);
        movePlayer(KeyCode.DownArrow, KeyCode.S, Vector3.back);
        rotatePlayer(KeyCode.LeftArrow, KeyCode.A, Vector3.down);
        rotatePlayer(KeyCode.RightArrow, KeyCode.D, Vector3.up);
        Jump(KeyCode.Space, Vector3.up);
    }

    // Collider-Triggers
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            Debug.Log("You Won!");
        }
    }
    private void OnTriggerStay(Collider other) { }
    private void OnTriggerExit(Collider other) { }
    // What to do when destroyed
    private void OnDestroy() { }
    // Movement methods
    private void movePlayer(bool cond, string action, Vector3 direction)
    {
        if (cond)
        {
            if (action == "move")
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            else if (action == "rotate")
                transform.Rotate(direction * rotateSpeed * Time.deltaTime);
            else if (action == "jump")
            {
                if (i > 0f)
                {
                    transform.Translate(direction * jumpHeight * Time.deltaTime);
                    i -= 1 * Time.deltaTime;
                }
            }
        }
    }
    private void Jump(KeyCode keycode, Vector3 direction)
    {
        movePlayer(Input.GetKey(keycode), "jump", direction);
        if (Input.GetKeyUp(keycode))
            i = jumpHeight;
    }
    private void movePlayer(KeyCode keycode, Vector3 direction)
    {
        movePlayer(Input.GetKey(keycode), "move", direction);
    }
    private void movePlayer(KeyCode keycode1, KeyCode keycode2, Vector3 direction)
    {
        movePlayer(Input.GetKey(keycode1) || Input.GetKey(keycode2), "move", direction);
    }

    private void rotatePlayer(KeyCode keycode, Vector3 direction)
    {
        movePlayer(Input.GetKey(keycode), "rotate", direction);
    }
    private void rotatePlayer(KeyCode keycode1, KeyCode keycode2, Vector3 direction)
    {
        movePlayer(Input.GetKey(keycode1) || Input.GetKey(keycode2), "rotate", direction);
    }
}
