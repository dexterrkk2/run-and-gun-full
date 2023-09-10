using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State{
    public interface IPlayerState
    {
        void Handle(PlayerController controller);
    }
}
