using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    [SerializeField]
    public float speed;

    Rigidbody2D Hejsan;
    // Start is called before the first frame update
    void Start()
    {
        Hejsan = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Hejsan.AddForce(new Vector2(-speed, 0),ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Hejsan.AddForce(new Vector2(speed, 0),ForceMode2D.Impulse);
        }
    }
}
