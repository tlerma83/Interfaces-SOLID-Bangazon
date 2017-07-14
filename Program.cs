using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}

public interface IWater {
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public interface ILand {
    double MaxLandSpeed { get; set; }
    void Drive();
}

public interface IFly {
    double MaxAirSpeed { get; set; }
    bool Winged { get; set; }
    void Fly();

}

public class JetSki : IVehicle, IWater
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    // public bool Winged { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }


    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class SailBoat : IVehicle, IWater
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("Whooooo, I'm a Sail Boat!");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Motorcycle : IVehicle, ILand
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }


    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Moped : IVehicle, ILand
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxLandSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("Look at that Moped go");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IFly
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxAirSpeed { get; set; } = 309.0;

  public void Drive()
  {
    throw new NotImplementedException();
  }

  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}

public class CessiPoo : IVehicle, IFly
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("The Cessipoo effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        CessiPoo cesiOneKenobi = new CessiPoo();
        Cessna plainCesna = new Cessna();

        List<IFly> flyList = new List<IFly>(){
            cesiOneKenobi, plainCesna
        };

        // With a single `foreach`, have each vehicle Fly()

        foreach (IFly item in flyList)
        {
            item.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        Motorcycle CrotchRocket = new Motorcycle();
        Moped SomeKindOfMoped = new Moped();

        // With a single `foreach`, have each road vehicle Drive()
        List<ILand> landList = new List<ILand>(){
            CrotchRocket, SomeKindOfMoped
        };

        foreach (ILand item in landList)
        {
            item.Drive();
        }
        // Build a collection of all vehicles that operate on water
        JetSki imAwesome = new JetSki();
        SailBoat superSailorMoon = new SailBoat();

        List<IWater>waterList = new List<IWater>(){
            imAwesome, superSailorMoon
        };
        
        // With a single `foreach`, have each water vehicle Drive()
        foreach (IWater item in waterList)
        {
            item.Drive();
        }
    }

}