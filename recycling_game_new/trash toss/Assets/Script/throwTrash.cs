using UnityEngine;
using System.Collections;

public class throwTrash : MonoBehaviour {
    public float multiplier;
    public int destroyTime;
    private Vector3 lastMoustPosition;
    private Vector3 newMousePosition;
    private Vector3 force;
    private Rigidbody2D rb;
    private bool moveByBelt;

	GameObject compost;
	Animator compostanim;

	GameObject landfill;
	Animator landfillanim;

    void Start()
    {
        moveByBelt = true;

		//starts idle animations
		compost = GameObject.FindGameObjectWithTag ("composite");
		compostanim = compost.GetComponent<Animator> ();

		landfill = GameObject.FindGameObjectWithTag ("landfill");
		landfillanim = landfill.GetComponent<Animator> ();
    }

    void Update()
    {
        if (moveByBelt)
            transform.Translate(Vector3.down * difficultySettings.moveSpeed);
    }

    void OnMouseDown()
    {
        lastMoustPosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        moveByBelt = false;
        newMousePosition = Input.mousePosition;
        force = newMousePosition - lastMoustPosition;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = false;
        rb.AddForce(force * multiplier);
        Destroy(gameObject, destroyTime);
		compostanim.SetInteger ("State", 0); //restarts compost idle animation
		landfillanim.SetInteger ("State", 0); //restarts landfill idle animation
    }

    /*void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objectPosition;
    }*/
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "recycle")
        {
            difficultySettings.score += 1;
            Destroy(gameObject);
        }

		if(coll.gameObject.tag == "composite")
		{
			difficultySettings.score += 1;
			compostanim.SetInteger ("State", 1); //switches idle to eating animation
			Destroy(gameObject);
		}

		if (coll.gameObject.tag == "landfill") {
			difficultySettings.score += 1;
			landfillanim.SetInteger ("State", 1); //switches idle to eating animation
			Destroy(gameObject);
		}
    }
}
