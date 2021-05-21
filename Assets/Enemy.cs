using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //protected will make the method to inhert but not to access by objects
    //private will make the method to access only within the class
    //public will make the class accessable every where (inherit, objects)
    public void Attack()
    {
        Debug.Log("Enemy Attack");

        GetComponent<Renderer>().material.color = Color.red;
    }
}
