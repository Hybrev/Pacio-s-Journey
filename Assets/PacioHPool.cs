using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacioHPool : MonoBehaviour {

    private GameObject coin;
    private float timeBeforeStart;
    private float timeBeforeInterval;
    public float columnMin;                                
    public float columnMax;
   

    void Start () {
        InvokeRepeating("Spawn", timeBeforeStart, timeBeforeInterval);

	}
	
	// Update is called once per frame
	private void Spawn () {
        var random = Random.Range(columnMin, columnMax);
        var pos = transform.position;
        pos.x = 10f;

        Instantiate(coin, pos, Quaternion.identity);
    }
}
