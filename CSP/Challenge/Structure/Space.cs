using System;
using System.Collections.Generic;

namespace CSP.Challenge.Structure
{
    enum SpaceType { General, Valet, FrequentFlyer }

    class Space : Level
    {
        public int SpaceId { get; set; }
        public int Time { get; set; }
        public SpaceType Type { get; set; }
        public List<Space> Spaces { get; set; }
        public List<CarOwner> CarOwners { get; set; }

        public Space()
        {
            Spaces = new List<Space>();
            CarOwners = new List<CarOwner>();
        }

        public void AddCar(CarOwner car, int spaceId, int levelId)
        {
            SpaceId = spaceId;
            LevelId = levelId;
            car.SpaceId = spaceId;
            car.SpaceLevel = levelId;
            Spaces.Add(this);
            CarOwners.Add(car);
        }

        public void RemoveCar(int spaceId, int levelId)
        {
            Space foundSpace = Spaces.Find(x => x.SpaceId == spaceId && x.LevelId == levelId);
            Spaces.Remove(foundSpace);
            if (foundSpace != null)
            {
                Console.WriteLine($"Car parked at L{levelId} space {spaceId} has been removed");
            }
            else
            {
                Console.WriteLine($"Parking level L{levelId} space {spaceId} is not taken.");
            }
        }

        public double ParkingCost(int spaceId, int levelId)
        {
            Space foundSpace = Spaces.Find(x => x.SpaceId == spaceId && x.LevelId == levelId);
            if (foundSpace != null)
            {
                CarOwner foundCar = CarOwners.Find(x => x.SpaceId == spaceId && x.SpaceLevel == levelId);
                if (foundCar != null)
                {
                    Time = 1;
                    if (foundCar.Status == SpaceType.General)
                    {
                        Console.WriteLine($"You parking space type is General and your total is ${Time * 1.0}.00");
                        return Time * 1.0;
                    }
                    else if (foundCar.Status == SpaceType.Valet)
                    {
                        Console.WriteLine($"Your parking space type is Valet and your total is ${Time * 2.0}.00");
                        return Time * 2.0;
                    }
                    else
                    {
                        Console.WriteLine($"Your parking space type is Frequent Flyer and your total is ${Time * 3.0}.00");
                        return Time * 3.0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Your parking is free today");
            }
            return 0.0;
        }

        public CarOwner GetOwner(int spaceId, int levelId)
        {
            CarOwner foundOwner = CarOwners.Find(x => x.SpaceId == spaceId && x.SpaceLevel == levelId);

            return foundOwner != null ? foundOwner : null;
        }

        public Space GetParkingSpace(string license, string name = "")
        {
            CarOwner foundOwner = CarOwners.Find(x =>
                x.Name.ToLower() == name.ToLower() || x.LicensePlate.ToLower() == license.ToLower());

            return foundOwner != null
                ? Spaces.Find(x => x.SpaceId == foundOwner.SpaceId && x.LevelId == foundOwner.SpaceLevel)
                : null;
        }
    }
}
