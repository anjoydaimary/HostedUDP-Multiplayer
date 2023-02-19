using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
        public int id;
        public string ip;
        public int conTimeOut = 0;
        public bool isDisconnected = false;
        public MPClientInfo info;
        public Transform playerGameObject;
        public List<MPCommand> cmdsSheldue;
}
