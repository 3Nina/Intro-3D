using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    void Start()
    {
        
    }

    public void ClonarCubos()  // Sin una funión publica el botón no puede ser ejecutado
    {
        Instantiate(cuboPrefab);
    }


}
