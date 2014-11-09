using UnityEngine;
using System.Collections;

public class ZombieAIScript : AiScript {

	private GameObject player;
	private SpriteAnimationManagerScript sams;
	public float floatHeight = 700.0f;
	private AudioSource soundEffect;
	private bool audioPlayed = false;

	private float attackCooldown = 2.0f;
	private float attackTimer = 0;

	// Use this for initialization
	public override void Start () {
		base.Start ();
		player = GameObject.Find("Main Character");
		sams = gameObject.GetComponent<SpriteAnimationManagerScript>();
		soundEffect = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		if(attackTimer < attackCooldown)
			attackTimer += Time.deltaTime;

		Debug.Log(attackTimer);

		Alerted ();
	}

	public override void Move ()
	{
		if(Mathf.Abs(player.transform.position.x - gameObject.transform.position.x) > player.GetComponent<BoxCollider2D>().size.x) {
			if(player.transform.position.x > gameObject.transform.position.x) {
				transform.position += new Vector3(speed * Time.deltaTime,0,0);
				sams.PlayAnimation("WalkRight");
			}
			else {
				transform.position -= new Vector3(speed * Time.deltaTime,0,0);
				sams.PlayAnimation("WalkLeft");
			}
		}
		else {
			if((player.transform.position - transform.position).magnitude < player.GetComponent<BoxCollider2D>().size.x + 0.2f)
				AttackPlayer();
		}

	}

	private void AttackPlayer() {
		Debug.Log("Attacking");
		if(attackTimer > attackCooldown) {
			Debug.Log("Dealing damage.");
			player.GetComponent<HealthScript>().Damage(5);
			attackTimer = 0;
		}
	}

	public override void Alerted ()
	{
		//Debug.Log ("alerted is called");
		base.Alerted ();
		if (isTriggered) 
		{
			if(audioPlayed == false)
			{
				audioPlayed = true;
				soundEffect.Play();
			}
			this.Move();
		}
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Bumper") {
			rigidbody2D.AddForce (new Vector2 (0, floatHeight * 1.5f));
		}
	}

}
