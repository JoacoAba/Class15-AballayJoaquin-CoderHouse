using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBullet : BulletMov
{
    public Transform Player;
   
    public override void Move()
    {
        transform.LookAt(Player);
        base.Move();
    }

    public override void DestroyBullet()
    {
        base.DestroyBullet();
    }
}
