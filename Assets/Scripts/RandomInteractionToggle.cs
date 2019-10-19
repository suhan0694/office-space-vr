using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomInteractionToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject1, gameObject2, gameObject3, gameObject4, gameObject5;



    // Start is called before the first frame update
   

    protected virtual void Update()
    {
        //light.SetActive(true);
    }

    public void toggleState(bool a)
    {
        Debug.Log("Entered code");
    	//All empty nothing to do
    	if(gameObject1 == null && gameObject2 == null && gameObject3 == null && gameObject4 == null && gameObject5 == null){
    		Debug.Log("Quitting because all null");
            return;
    	}

        if(disableIfActive(gameObject1) || disableIfActive(gameObject2) || disableIfActive(gameObject3) || disableIfActive(gameObject4) || disableIfActive(gameObject5)){
        	//If any object is active, disbale it and quit
        	Debug.Log("Disabled one object, returning");
            return;
        } else{
            System.Random rnd = new System.Random();
        	bool enabledObject = false;

        	do{
                int winner = rnd.Next(1, 5);
                Debug.Log("Winner is " + winner);
        		if(winner == 1){
                    Debug.Log("Enabling " + winner);
        			enabledObject = enableIfAvailable(gameObject1);
	        	} else if(winner == 2){
                    Debug.Log("Enabling " + winner);
	        		enabledObject = enableIfAvailable(gameObject2);
	        	} else if(winner == 3){
                    Debug.Log("Enabling " + winner);
	        		enabledObject = enableIfAvailable(gameObject3);
	        	} else if(winner == 4){
                    Debug.Log("Enabling " + winner);
	        		enabledObject = enableIfAvailable(gameObject4);
	        	} else if(winner == 5){
                    Debug.Log("Enabling " + winner);
	        		enabledObject = enableIfAvailable(gameObject5);
	        	}	
        	} while(!enabledObject); 
        }
    }

    public bool enableIfAvailable(GameObject gameObject){
    	if(gameObject == null){
    		return false;
    	}
    	gameObject.SetActive(true);
    	return true;
    }

    public bool disableIfActive(GameObject gameObject){
    	if(gameObject == null){
    		return false;
    	}
    	bool isEnabled = gameObject.activeSelf;
    	if(isEnabled){
    		gameObject.SetActive(false);
    	}
    	return isEnabled;
    }
}
