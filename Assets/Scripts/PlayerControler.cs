using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*  */
public class PlayerControler : MonoBehaviour {
	public float speed;
	private int count;
	public Text countText;
	public Text winText;

	void Start()
	{
		count = 0;
		countText.text = "Count: " + count.ToString();
		winText.text = "";
	}

	/* Chamada para realizar calculos fisicos */
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 moviment = new Vector3(moveHorizontal, 0.0F, moveVertical);

		GetComponent<Rigidbody>().AddForce(moviment * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			countText.text = "Count: " + count.ToString();
		}

		if(count == 10)
			winText.text = "You Win!!";
	}
}
