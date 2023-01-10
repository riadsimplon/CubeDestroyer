using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using Unity.VisualScripting;

public class cube_spawner : MonoBehaviour
{
    [SerializeField] private int limitSpawned;
    [SerializeField] private Transform objectToSpawned;
    [SerializeField] private int spawnSpeed;
    private int numberSpawned;
    private List<Transform> spawnList = new List<Transform>();
    private float time = 0f;
    private Transform spawnedObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 

        time += Time.deltaTime;

     if (time >= spawnSpeed && numberSpawned<limitSpawned)
        {
            Debug.Log(time);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range (0f,Screen.width), Random.Range(0f,Screen.height), Random.Range(10f, 30f)));
            spawnedObject = Instantiate(objectToSpawned);
            spawnedObject.position = worldPosition;
            numberSpawned++;
            spawnList.Add(spawnedObject);
            time = 0f;
        }
        
  }

    
}
