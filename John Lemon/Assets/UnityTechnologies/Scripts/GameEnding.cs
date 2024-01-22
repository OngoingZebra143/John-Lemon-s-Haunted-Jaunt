using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration =1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    bool m_IsplayerAtExit;
    float m_Timer;

    // Update is called once per frame
    void Update()
    {
        if(m_IsplayerAtExit)
        {
            EndLevel();
        }
    }
    void EndLevel()
    {
       m_Timer+= Time.deltaTime;
       exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

       if(m_Timer > fadeDuration + displayImageDuration);
       {
        Application.Quit();
       }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            m_IsplayerAtExit = true;
        }
    }
}
