using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{

  [SerializeField] private Button serverb;
  [SerializeField] private Button hostb;
  [SerializeField] private Button clientb;

  void Start()
  {

  }

  void Update()
  {

  }


  private void Awake()
  {
    serverb.onClick.AddListener(() =>
    {
      NetworkManager.Singleton.StartServer();
    });

    clientb.onClick.AddListener(() =>
    {
      NetworkManager.Singleton.StartClient();
    });
    
    hostb.onClick.AddListener(() => {
      NetworkManager.Singleton.StartHost();
    });
  }
}
