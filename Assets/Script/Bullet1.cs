using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private GameObject parent; //comment 1
    public GameObject Parent { set { parent = value; } get { return parent; } }
    private float speed = 7.0F;
    private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }

    private SpriteRenderer sprite;

    public Color Color
    {
        // WE go
        // Here we go!
        set { sprite.color = value; }

    }


    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        Destroy(gameObject, 0.1F);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0F;
    }

    public IEnumerator OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit && unit.gameObject != parent)
        {
            yield return new WaitForSeconds(50f);
            Destroy(gameObject); // comment 2
        }
        //другое
        //commet3
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(50);
    }
}

