using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{

    public HealthBar health;
    public float collisionDamage = 10f;
    public InstallMechanic install;
    public CheckpointSingle CheckpointSinglePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    /*
    public void onCollisionEnter(Collision collision)
    {
      if (!install && collision.gameObject.CompareTag("Checkpoint"))
        {
            health.TakeDamage(collisionDamage);
        }
    }
    */
}

