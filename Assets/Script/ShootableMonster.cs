﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableMonster : Monster
{

    [SerializeField]
    private float rate = 2.0F;

    [SerializeField]
    private Color bulletColor = Color.white;

    private Bullet bullet;


    protected override void Awake()
    {
        bullet = Resources.Load<Bullet>("Bol");
    }

    protected override void Start()
    {
        InvokeRepeating("Shoot", rate, rate);
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet1 bullet1 = collider.GetComponent<Bullet1>();

        Unit unit = collider.GetComponent<Unit>();
        if (bullet1)
        {
            ReceiveDamage();
        }
        if (unit is Character)
        {
            if (Mathf.Abs(unit.transform.position.x - transform.position.x) < 0.55F)
                ReceiveDamage();
            else unit.ReceiveDamage();
        }
    }

    private void Shoot()
    {
        Vector3 position = transform.position; position.y += 0.5F;

        Bullet newBullet = Instantiate(bullet, position, bullet.transform.rotation) as Bullet;

        newBullet.Parent = gameObject;
        newBullet.Direction = -newBullet.transform.right;
        newBullet.Color = bulletColor;
    }
}
