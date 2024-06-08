using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyMaterial : MonoBehaviour
{
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
        Color col = Color.blue;

        renderer.material.color = col;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
