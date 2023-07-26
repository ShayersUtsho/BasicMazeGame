using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMessage : MonoBehaviour
{
    [SerializeField] private PlayerBehavior player;
    [SerializeField] private float speed = 1f;
    private float i = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.win)
        {
            if (i < 170)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                i+= 1f;
            }
        }
    }
}
