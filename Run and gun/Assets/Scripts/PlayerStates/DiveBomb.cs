using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class DiveBomb : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
             _playerController.rb.AddForce(_playerController.maxSpeed * Vector3.down*_playerController.diveBombMod);
            _playerController.lastState = 0;
        }
    }
}
