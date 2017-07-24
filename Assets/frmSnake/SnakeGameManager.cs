using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Assets.frmSnakeAssets
{
    public enum GameState
    {
        Running,
        Stopped
    }
    class SnakeGameManager
    {
        public GameState gameState;
        //constructor
        public SnakeGameManager()
        {
            gameState = GameState.Stopped;
        }
        
    }
}
