using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{


    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;

    private float topScore = 0.0f;
    public Text scoretext;


    private bool gamestart = false;
    public Text starttext;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;   // not fall after click 
        rb2d.velocity = Vector3.zero;   // not fall after click 
    }


    void Update()

    {


        if(Input.GetKeyDown(KeyCode.Space) && gamestart == false)
        {
            gamestart = true;
            starttext.gameObject.SetActive(false);
            rb2d.gravityScale = 5;

        }
        if (gamestart == true)
        {



            if (moveInput > 0)   // obracanie lewo/prawo 
            {

                this.GetComponent<SpriteRenderer>().flipX = false;

            }

            else
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }



            if (rb2d.velocity.y > 0 && transform.position.y > topScore)   // change score moving upwards / current position greater than topscore 
            {

                topScore = transform.position.y; // update top score to new postiinon 
            }

            scoretext.text = "KILLED DEMONS:" + Mathf.Round(topScore).ToString(); //  



            if(transform.position.y + 30 < topScore)
        {
                SceneManager.LoadScene("GameOver");
            }
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (gamestart == true)
        {

            moveInput = Input.GetAxis("Horizontal");



            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

        }
    }
}
