﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYoTestDemo.Models;
using YoYoTestDemo.ViewModel;

namespace YoYoTestDemo.Services
{
    public interface IPlayerService
    {
        List<Player> GetPlayers();
        Player warnPlayer(int playerId);
        PlayerResultViewModel resultPlayer(int playerId, string result);
    }

    public class PlayerService : IPlayerService
    {

        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            var player1 = new Player
            {
                id = 1,
                name = "Ashton Eaton",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player2 = new Player
            {
                id = 2,
                name = "Bryan Clay",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player3 = new Player
            {
                id = 3,
                name = "Deam Karnazes",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player4 = new Player
            {
                id = 4,
                name = "Usain Bolt",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

           //Adding players

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            

            return players;
        }

        public PlayerResultViewModel resultPlayer(int playerId, string result)
        {
            var playerResult = new PlayerResultViewModel();
            var playersList = GetPlayers();
            int editIndex = playersList.FindIndex(o => o.id == playerId);
            playerResult.id = playersList[editIndex].id;
            playerResult.result = result;
            //save data someware..

            return playerResult;
        }

        public Player warnPlayer(int playerId)
        {
            var playersList = GetPlayers();
            int editIndex = playersList.FindIndex(o => o.id == playerId);
            playersList[editIndex].warn = true;
            //save data someware..


            return playersList[editIndex];
        }
    }

}
