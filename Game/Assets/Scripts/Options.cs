using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

    //pause menu appear when esc key is pressed
    public GameObject m_PauseMenu;

    //when pause is active
    bool m_pause = false;

	
	void Start () {

        m_PauseMenu.SetActive(m_pause);
	}
	
	
	void Update () {
	
        //when user press esc - show menu
        if (Input.GetKeyDown("escape"))
        {
            m_pause = !m_pause;
            m_PauseMenu.SetActive(m_pause);
        }
	}
}
