using System;

public class SpaceAge
{    
    public double Years { get; set; }

    public SpaceAge(int seconds)
    {
        Years = TimeSpan.FromSeconds(seconds).TotalDays / 365.25;
    }

    public double OnEarth() => Years;

    public double OnMercury() => Years / 0.2408467;

    public double OnVenus() => Years / 0.61519726;

    public double OnMars() => Years / 1.8808158;

    public double OnJupiter() => Years / 11.862615;

    public double OnSaturn() => Years / 29.447498;

    public double OnUranus() => Years / 84.016846;

    public double OnNeptune() => Years / 164.79132;
}