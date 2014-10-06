﻿namespace TheSlum.GameEngine
{
    using System;
    using Characters;
    using Items;

    public class MyEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character newCharacter;
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    newCharacter = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]), 
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;
                case "mage":
                    newCharacter = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;
                case "healer":
                    newCharacter = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            Character characterToAcceptIitem = GetCharacterById(inputParams[1]);
            Item itemToAdd;
            switch (inputParams[2])
            {
                case "axe":
                    itemToAdd = new Axe(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "shield":
                    itemToAdd = new Shield(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "injection":
                    itemToAdd = new Injection(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "pill":
                    itemToAdd = new Pill(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
            }
        }
    }
}
