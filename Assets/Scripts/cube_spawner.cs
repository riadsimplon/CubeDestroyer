using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class cube_spawner : MonoBehaviour
{

    [SerializeField] private Transform objectToSpawned;
    [SerializeField] private int spawnSpeed = 3;
    [SerializeField] private Transform spawnedDistance;
    [SerializeField] private int maxSpawned;
    private List<Transform> spawnList = new List<Transform>();
    private float time = Time.deltaTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       private float time = Time.deltaTime;

        if(time = 1/spawnSpeed &&)
        {vector 3 worldPosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.nearClip);
        Instantiate(objectToSpawned);
        }
        


    }
}
