using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Vector3 m_Position;
	float m_Rotation; 
	public float m_speed;
	
	
	public Rigidbody m_rigidbody;
	public KeyCode forward 		=  KeyCode.W;
	public KeyCode backward 	=  KeyCode.S;
	public KeyCode rotateLeft   =  KeyCode.A;
	public KeyCode rotateRight  =  KeyCode.D;
	public float m_jumpCooldown = 0;
	public KeyCode Jump  		=  KeyCode.Space;
	
	// Use this for initialization
	void Start () 
	{
		m_Position = transform.position;
		m_Rotation = 0.1f;
		m_speed = 5.0f;
		m_jumpCooldown = 0;
		m_rigidbody = GetComponent<Rigidbody>();
		
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		m_jumpCooldown -= Time.deltaTime;
		UserInput ();
	}
	
	void UserInput()
	{
		
		if (Input.GetKey (forward)) 
		{
			transform.Translate (Vector3.forward * m_speed * Time.deltaTime);
		}
		
		
		if (Input.GetKey (rotateRight)) 
		{
			transform.Rotate (new Vector3 (0, 1, 0), 3);
		}
		
		if (Input.GetKey (rotateLeft)) 
		{
			transform.Rotate (new Vector3 (0, 1, 0), -3);
		}
		
		
		if (Input.GetKey (backward)) 
		{
			transform.Translate (Vector3.back * m_speed * Time.deltaTime);
		}
		
		
		if(Input.GetKey(Jump) && m_jumpCooldown < 0)
		{
			
			m_rigidbody.AddForce(new Vector3(0,300,0));
			m_jumpCooldown = 1.0f;
		}
	}
}
