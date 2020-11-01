using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private float mass = 1;
    public void Initialize()
    {
        GetComponent<Rigidbody2D>().mass = mass;
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IEater eater = collision.gameObject.GetComponent<IEater>();
        if (eater==null)
        {
            //TODO score substruct, smash animation
            Destroy(gameObject);
        }
        else
        {
            eater.Eat(this);
        }
    }

}
