using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private MeshRenderer renderer;
    public bool normal;
    public GameObject banner;
    public int counter = 0;
    public bool first = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }

    private void Awake()
    {
        Color col = Color.white;
        if (normal)
        {
            col = Color.blue;
        }
        
        renderer = gameObject.GetComponent<MeshRenderer>();

        renderer.material.color = col;
     }

    // Update is called once per frame
    void Update()
    {
        if(counter == 2)
        {
            gameObject.SetActive(false);
            Debug.Log("ferig");
            Application.Quit();
            
        }
        else
        {
            if (first)
            {
                Color col = Color.white;
                if (normal)
                {
                    col = Color.blue;
                }

                renderer = gameObject.GetComponent<MeshRenderer>();

                renderer.material.color = col;

                first = false;

            }


            if (!banner.activeSelf)
            {
                gameObject.SetActive(true);
                StartCoroutine(waiterColor());

            }
        }
        
        
        
    }
    IEnumerator waiterColor()
    {
        yield return new WaitForSeconds(3);

        if(normal)
        {
            Color colnew = Color.white;

            renderer.material.color = colnew;

        }
        yield return new WaitForSeconds(2);

        
        yield return new WaitForSeconds(5);
        counter = counter + 1;

        if (counter == 2)
        {
            gameObject.SetActive(false);
            Debug.Log("ferig");
            Application.Quit();
        }
        else
        {
            banner.SetActive(true);
            first = true;
            Debug.Log(counter);
            gameObject.SetActive(false);
        }
        




    }
}
