using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBalls : MonoBehaviour
{
    public GameObject blue_ball;
    public GameObject red_ball;
    public GameObject green_ball;


    // Start is called before the first frame update
    void Start()
    {
        for (int r = 0; r < 100; r++)
        {
            Instantiate(red_ball, new Vector3(Random.Range(-21f, 26f), 1, Random.Range(2f, 50f)), Quaternion.identity);
        }

        for (int g = 0; g < 50; g++)
        {
            Instantiate(green_ball, new Vector3(Random.Range(-21f, 26f), 1, Random.Range(2f, 50f)), Quaternion.identity);
        }

        for (int b = 0; b < 25; b++)
        {
            Instantiate(blue_ball, new Vector3(Random.Range(-21f, 26f), 1, Random.Range(2f, 50f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
