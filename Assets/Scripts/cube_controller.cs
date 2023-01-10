using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Numerics;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.SceneManagement;

public class cube_controller : MonoBehaviour
{
    [SerializeField] private float spawnedSpeed;
   


   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Camera.main.transform.transform.forward*Time.deltaTime*-spawnedSpeed);
        
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }


}
