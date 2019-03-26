using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameMode
{
    WAVE,
    ENDLESS
}

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    GameMode gameMode;

    public PlayerController PlayerOne;

    public Shop shop;

    public int score;

    public UIManager _UIManager;

    public WaveManager waveManager;

    public EnemySpawner enemySpawner;

	void Awake () {
		if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            if(Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(this.gameObject);

        Init();

        SetGameMode(GameMode.ENDLESS);
	}
	

    void Init()
    {
        PlayerOne = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        if(PlayerOne == null)
        {
            Debug.LogWarning("PlayerController Component not found");
        }

        
    }

    public void UpdateScore(int amount)
    {
        score += amount;

        _UIManager.UpdateScoreText(score);
    }

	// Update is called once per frame
	void Update () {
       // GetInputs();
	}

    void SetGameMode(GameMode gm)
    {
        gameMode = gm;

        if (gm != GameMode.WAVE)
            waveManager.gameObject.SetActive(false);
    }

    public GameMode GetGameMode()
    {
        return gameMode;
    }
   
}
