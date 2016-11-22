using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	//Private Variables 
	private int _livesValue; 
	private int _scoreValue; 

	[Header("UI Objects")]
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel; 
	//public Text FinalScoreLabel; 
	//public Button RestartButton; 
	public GameObject Player; 
	public GameObject Enemy; 

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				//this._gameOver (); 
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}

	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}


	// Use this for initialization
	void Start () {
		this.LivesValue = 5; 
		this.ScoreValue = 5; 
		this.GameOverLabel.gameObject.SetActive (false);
		//this.FinalScoreLabel.gameObject.SetActive (false);
		//this.RestartButton.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	//Method for when Player collides with the enemy, will take away one life if hit and will add score if player passes the enemy
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Enemy")) {
			this.LivesValue -= 1;
		}
			
	}
		
}
