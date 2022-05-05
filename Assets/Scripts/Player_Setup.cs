using UnityEngine;
using UnityEngine.Networking;

public class Player_Setup: MonoBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera SceneCamera;

    // Use this for initialization
    void Start()
    {
        bool isLocalPlayer = true;
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            SceneCamera = Camera.main;
            if (SceneCamera != null)
            {
                SceneCamera.gameObject.SetActive(false);
            }
        }

    }

    private void OnDisable()
    {
        if (SceneCamera != null)
        {
            SceneCamera.gameObject.SetActive(true);
        }
    }


}
