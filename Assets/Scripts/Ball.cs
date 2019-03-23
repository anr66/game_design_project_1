using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static int score_counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string my_material_name = GetComponent<Renderer>().material.name;
        var color_only = my_material_name.Substring(0, 1);

        Debug.Log(color_only);

        if (color_only == "r")
        {
            score_counter += 1;
            Destroy(transform.root.gameObject);
        }

        else if (color_only == "g")
        {
            score_counter += 2;
            Destroy(transform.root.gameObject);
        }

        else if (color_only == "b")
        {
            score_counter += 3;
            Destroy(transform.root.gameObject);
        }

    }
}
