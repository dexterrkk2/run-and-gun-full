using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class StopState: MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
            _playerController.CurrentSpeed = 0;

        }
    }
}