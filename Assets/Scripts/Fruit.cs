using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private float mass = 1;
    private ScoreController scoreController;
    [SerializeField] private int score = 10;
    public void Initialize(ScoreController scoreController)
    {
        GetComponent<Rigidbody2D>().mass = mass;
        this.scoreController = scoreController;
        score =(int)(mass * 10f);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IEater eater = collision.gameObject.GetComponent<IEater>();
        if (eater==null)
        {
            //TODO score substruct, smash animation
            scoreController.Score -= score;
            Destroy(gameObject);
        }
        else
        {
            eater.Eat(this);
            scoreController.Score += score;
        }
    }

}
