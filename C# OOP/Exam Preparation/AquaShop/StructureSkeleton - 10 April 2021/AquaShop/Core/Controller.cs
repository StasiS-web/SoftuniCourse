using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly DecorationRepository decorations;
        private readonly ICollection<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;
            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.aquariums.Add(aquarium);

            return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;

            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidDecorationType));
            }

            this.decorations.Add(decoration);

            return String.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration = this.decorations.FindByType(decorationType);
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if(decorations == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
           
            aquarium?.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            return String.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            IFish fish;

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidFishType));
            }

            string aquariumType = aquarium?.GetType().Name.Replace("Aquarium", String.Empty);
            string fishTypeSt = fishType.Replace("Fish", String.Empty);

            if (aquariumType == fishTypeSt)
            {
                aquarium.AddFish(fish);
            }

            return aquariumType != fishTypeSt ? OutputMessages.UnsuitableWater : 
                String.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aquarium?.Fish.Feed();

            return String.Format(OutputMessages.FishFed, aquarium?.Fish.Count);
        }

        public string CalculateValue(string aquariumName)
        {
            throw new NotImplementedException();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            string fishName = this. ? 
                    String.Join(", ", this. )) : "none";

            sb.AppendLine($"{Aquarium.Name} ({Aquarium.GetType().Name}):")
                .AppendLine($"Fish: {fishName}")
                .AppendLine($"!Decorations: {decorationsCount}")
                .AppendLine($"Comfort: {aquariumComfort}");

            return sb.ToString();
        }
    }
}
