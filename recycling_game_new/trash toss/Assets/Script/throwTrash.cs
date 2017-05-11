using UnityEngine;
using System.Collections;

public class throwTrash : MonoBehaviour {
    public float digestionTime;
    public float multiplier;
    public int destroyTime;

    private Vector3 lastMousePosition;
    private Vector3 newMousePosition;
	private Vector2 distance;
	private Vector3 distance2;
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
		compost = GameObject.Find("composite bin");
		compostanim = compost.GetComponent<Animator> ();

		landfill = GameObject.Find("landfill bin");
		landfillanim = landfill.GetComponent<Animator> ();
    }

    void Update()
    {
		if (moveByBelt)
			transform.Translate(Vector3.down * difficultySettings.moveSpeed);
    }
		

    void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }


    void OnMouseUp()
	{
		// disable collider so player cannot swipe twice

		moveByBelt = false;
		newMousePosition = Input.mousePosition;
		distance = newMousePosition - lastMousePosition;

		// making sure that x and y values are not 0
		if (Mathf.Abs(distance.x) < 0.1f)
			distance.x = 0.1f;
		if (Mathf.Abs(distance.y) < 0.1f)
			distance.y = 0.1f;
		
		float xsquare = distance.x * distance.x;
		float ysquare = distance.y * distance.y;
		distance2 = distance / (Mathf.Sqrt (xsquare + ysquare));

		rb = GetComponent<Rigidbody2D> ();
		rb.isKinematic = false;
		rb.AddForce (distance2 * multiplier);

		Destroy (gameObject, destroyTime);
		compostanim.SetInteger ("State", 0); //restarts compost idle animation
		landfillanim.SetInteger ("State", 0); //restarts landfill idle animation
	}


	/*
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objectPosition;
    } */
    

    
	// bin collisions
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == gameObject.tag)
        {
            difficultySettings.score += 1;
            if (gameObject.tag == "recycle")
            {
                difficultySettings.digestionTime_rec = digestionTime;
            }

            if (gameObject.tag == "composite")
            {
                difficultySettings.digestionTime_com = digestionTime;
                compostanim.SetInteger("State", 1); //switches idle to eating animation
            }

            if (gameObject.tag == "landfill")
            {
                landfillanim.SetInteger("State", 1); //switches idle to eating animation
            }
            Destroy(gameObject);
        }
    }
}