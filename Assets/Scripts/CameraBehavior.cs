using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Transform behindPlayer;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = behindPlayer.position;
        transform.rotation = behindPlayer.rotation;
    }
}
