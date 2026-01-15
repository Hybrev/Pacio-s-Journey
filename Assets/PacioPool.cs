using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacioPool : MonoBehaviour
{

    public GameObject coin;
    public float timeBeforeStart;
    public float timeBeforeInterval;
  


    void Start()
    {
        InvokeRepeating("Spawn", timeBeforeStart, timeBeforeInterval);

    }

    // Update is called once per frame
    private void Spawn()
    {
        var random = Random.Range(2f, -3.3f);
        var pos = transform.position;
        pos.y = random;

        

        Instantiate(coin, pos, Quaternion.identity);

    }
     


}
