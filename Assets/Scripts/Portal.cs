using FishNet;
using FishNet.Connection;
using FishNet.Managing.Scened;
using FishNet.Object;
using FishNet.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Portal : NetworkBehaviour
{
    [Scene]
    public string SceneA;
    [Scene]
    public string SceneB;
    [Scene]
    public string SceneC;

    public void OnClickSceneA()
    {
        ClientManager.Connection.FirstObject.GetComponent<PlayerSceneManager>().ServerLoadScene(SceneB);
    }
    public void OnClickSceneB()
    {
        ClientManager.Connection.FirstObject.GetComponent<PlayerSceneManager>().ServerLoadScene(SceneB);
    }
    public void OnClickSceneC()
    {
        ClientManager.Connection.FirstObject.GetComponent<PlayerSceneManager>().ServerLoadScene(SceneC);
    }


   


}
