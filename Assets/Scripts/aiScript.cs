using UnityEngine;
using System.Collections;

public class AiScript : MonoBehaviour {

	public float speed;
	public GameObject triggerVolume;
	public Vector2 moveTarget;
	protected bool isTriggered;

	// Use this for initialization
	public virtual void Start () {
		isTriggered = triggerVolume.GetComponent<TriggerVolumeScript> ().isTriggered;
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}

	public virtual void Move(){

	}

	public virtual void Alerted(){
		isTriggered = triggerVolume.GetComponent<TriggerVolumeScript> ().isTriggered;
		moveTarget = triggerVolume.GetComponent<TriggerVolumeScript> ().playerPosition;
	}

}
