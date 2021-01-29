using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private List<VoiceOverCatalog> selectedVoiceOvers;
    
    private static GameManager gameManager;
    public static GameManager Instance
    {
        get
        {
            return gameManager;
        }
    }

    private void Awake() {
        if (gameManager ==  null)
		{
			gameManager = this;
            gameManager.Init();
		}
		else
		{
			Destroy(gameObject);
			return;
		}
		// Persistent
		DontDestroyOnLoad(gameObject);
    }

    private void Init() {
        if (selectedVoiceOvers == null) {
            selectedVoiceOvers = new List<VoiceOverCatalog>();
        }
    }

    public void AddSelectedVoiceOver(VoiceOverCatalog selected) {
        selectedVoiceOvers.Add(selected);
    }
}
