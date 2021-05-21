using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : Enemy
{
    public bool isAttacking = false;

    public void Update()
    {
        if (isAttacking == true)
        {
            Attack();
            base.Attack();
        }
    }

    /*public void Attack()
    {
        Debug.Log("This is robot attack");
    }*/
}
