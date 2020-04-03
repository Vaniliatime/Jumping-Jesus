using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{


    public GameObject jesus;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    private GameObject myPlat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.StartsWith("platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-10f, 10f), jesus.transform.position.y + (20 + Random.Range(4f, 5f))), Quaternion.identity);


            }
            else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-10f, 10f), jesus.transform.position.y + (20 + Random.Range(4f, 5f)));

            }



        }

        else if (collision.gameObject.name.StartsWith("spring"))

        {

            if (Random.Range(1,7) == 2)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-10f, 10f), jesus.transform.position.y + (20 + Random.Range(4f, 5f)));

            }
            else
            {

                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-10f, 10f), jesus.transform.position.y + (20 + Random.Range(4f, 5f))), Quaternion.identity);


            }




        }

    }

}





















    



