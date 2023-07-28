using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float vertical, horizontal;
    Rigidbody2D thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void MovePlayer() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        thePlayer.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}
