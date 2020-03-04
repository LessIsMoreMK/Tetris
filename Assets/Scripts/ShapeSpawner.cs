using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour {

    public GameObject[] shapes;

    public void SpawnShape()
    {
        int ShapeIndex = Random.Range(0, 6);
        Instantiate(shapes[ShapeIndex], transform.position, Quaternion.identity);
    }

    private void Start()
    {
        SpawnShape();
    }
}
