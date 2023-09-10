using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class StartState : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            transform.localScale = new Vector3(1, 1, 1);
            if (!_playerController)
            {
                _playerController = playerController;
            }
            _playerController.lastState = 0;
            playerController.isDiving = false;
        }
    }
}
