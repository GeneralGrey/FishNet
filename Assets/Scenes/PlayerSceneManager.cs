using FishNet.Connection;
using FishNet.Managing.Scened;
using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSceneManager : NetworkBehaviour
{
    [ServerRpc]
    public void ServerLoadScene(string Scene)
    {
        SceneLoadData sld = new SceneLoadData(Scene);
        sld.ReplaceScenes = ReplaceOption.All;
        sld.MovedNetworkObjects = new FishNet.Object.NetworkObject[] { NetworkObject };
        sld.Options.AutomaticallyUnload = true;
        NetworkManager.SceneManager.LoadConnectionScenes(Owner, sld);
    }
   
}
