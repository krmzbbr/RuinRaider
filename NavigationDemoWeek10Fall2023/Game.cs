using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemoWeek10Fall2023
{
    public class Game
    {
        //Player name is stored here
        public string PlayerName { get; set; }

        public string PlayerAvatarPath { get; set; }

        public List<Location> Locations { get; set; } = new List<Location>();

        public Game()
        {
            //Ruin Locations

            //A Maze
            //NPC: Minotaur
            //Item: Crown
            NPC minotaur = new NPC()
            {
                Name = "Minotaur",
                Description = "A large bull-headed humanoid",
                ImagePath = "minotaur.jpg"
            };
            Item crown = new Item()
            {
                Name = "Crown",
                Description = "A golden crown with jewels",
                ImagePath = "crown.png"
            };
            Location maze = new Location()
            {
                Name = "Maze",
                Description = "A maze of twisty passages",
                ImagePath = "maze.png",
                NPC = minotaur,
                Item = crown
            };
            Locations.Add(maze);


            //Trap room
            //NPC: Talking Skull
            //Item: Coin

            NPC talkingSkull = new NPC()
            {
                Name = "Talking Skull",
                Description = "A skull with glowing eyes",
                ImagePath = "skull.png"
            };
            Item coin = new Item()
            {
                Name = "Coin",
                Description = "A gold coin",
                ImagePath = "coin.jpg"
            };
            Location trapRoom = new Location()
            {
                Name = "Trap Room",
                Description = "A room with a trap",
                ImagePath = "traproom.jpg",
                NPC = talkingSkull,
                Item = coin
            };
            Locations.Add(trapRoom);

            //Cavern
            //NPC: Giant spider
            //Item: Silk

            NPC giantSpider = new NPC()
            {
                Name = "Giant Spider",
                Description = "A giant spider",
                ImagePath = "spider.png"
            };
            Item silk = new Item()
            {
                Name = "Silk",
                Description = "A bundle of silk",
                ImagePath = "silk.jpg"
            };
            Location cavern = new Location()
            {
                Name = "Cavern",
                Description = "A large cavern",
                ImagePath = "cavern.jpg",
                NPC = giantSpider,
                Item = silk
            };
            Locations.Add(cavern);

            //Forest
            //NPC: A talking tree
            //Item: Chest of gold
            NPC talkingTree = new NPC()
            {
                Name = "Talking Tree",
                Description = "A tree that can talk",
                ImagePath = "talkingtree.png"
            };
            Item chestOfGold = new Item()
            {
                Name = "Chest of Gold",
                Description = "A chest of gold",
                ImagePath = "chestofgold.png"
            };
            Location forest = new Location()
            {
                Name = "Forest",
                Description = "A forest",
                ImagePath = "forest.jpg",
                NPC = talkingTree,
                Item = chestOfGold
            };
            Locations.Add(forest);

            //Tombs
            //NPC: Pharaohs
            //Item:  precious ruby
            NPC pharaohs = new NPC()
            {
                Name = "Pharaohs",
                Description = "Pharaohs",
                ImagePath = "pharaoh.png"
            };

            Item preciousRuby = new Item()
            {
                Name = "Precious Ruby",
                Description = "A precious ruby",
                ImagePath = "preciousruby.png"
            };
            Location tombs = new Location()
            {
                Name = "Tombs",
                Description = "Tombs",
                ImagePath = "tombs.jpg",
                NPC = pharaohs,
                Item = preciousRuby
            };
            Locations.Add(tombs);

        }



    }
}
