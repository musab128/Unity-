
using UnityEngine;
using UnityEngine.Networking;
public class DisableStuff : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] WhoToDisable;
     
    public Camera cam;
    private void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < WhoToDisable.Length; i++)
            {
                WhoToDisable[i].enabled = false;
            }
        }else
        {
            cam = Camera.main;
            if (cam != null)
            {
                cam.gameObject.SetActive(false);
            }
        }
    }
    private void OnDisable()
    {
        cam.gameObject.SetActive(true);
    }
}
