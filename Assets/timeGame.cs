using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class timeGame : MonoBehaviour
{
    float roundStartDelayTime = 3;

    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("press the spacebar one you think the time is up");
        Invoke("setNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted)
        {
            inputReceived();
        }
    }

    void inputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("you waited for " + playerWaitTime + " seconds. That's " + Mathf.Round(error) + " seconds off. " + GenerateMessage(error));
        Invoke("setNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error < .15f)
        {
            message = " OUSTANDING";
        }
        else if (error < .75f)
        {
            message = " good job";
        }
        else if (error < 1.25f)
        {
            message = " acceptable";
        }
        else if (error < 2f)
        {
            message = " kinda close i guess";
        }
        else
        {
            message = " you suck";
        }

        return message;
    }

    void setNewRandomTime()
    {
        waitTime = Random.Range(5, 11); // Random.Range will have the ability to give the minimun number but not the maximum number
        // so in the example above it can give you 5 but cant give you 11
        roundStarted = true;
        roundStartTime = Time.time;
        print(waitTime + " seconds.");
    }
}
