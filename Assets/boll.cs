using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    public Vector2 ballspeed;
    Rigidbody2D Boll;

    // Start is called before the first frame update
    void Start()
    {
        Boll = GetComponent<Rigidbody2D>();
        Boll.AddForce(new Vector2(ballspeed.x, ballspeed.y));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGameObject = collision.gameObject;
        AllaGunnillor hitEnemy = otherGameObject.GetComponent<AllaGunnillor>();

        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage();
        }
    }
}
