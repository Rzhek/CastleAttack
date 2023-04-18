using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    public GameObject explosion; 
    
    void OnCollisionEnter(Collision other)
    {   
        if (other.gameObject.CompareTag("Ground"))
        {
            Score score = FindObjectOfType<Score>();
            if (score){
                score.EndLevel();
            }

            if (explosion) {
                Destroy(gameObject);
                Instantiate(explosion, transform.position, Quaternion.identity);
            }
            
        }
    }
}
