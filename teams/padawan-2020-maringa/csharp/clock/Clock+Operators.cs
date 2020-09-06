using System;

public partial class Clock : IEquatable<Clock>
{   
    /// <summary>
    /// Returns a positive Clock.
    /// </summary>   
    public static Clock operator +(Clock clock) => new Clock (clock.Hours, clock.Minutes);

    /// <summary>
    /// Returns a negative clock (makes both hours and minutes negative).
    /// </summary> 
    public static Clock operator -(Clock clock) => new Clock ( - clock.Hours, - clock.Minutes);

    /// <summary>
    /// Adds one clocktime to another.
    /// </summary> 
    public  static Clock operator +(Clock clock, Clock other) => new Clock (clock.Hours + other.Hours, clock.Minutes + other.Minutes);

    /// <summary>
    /// Subtract the time of a clock from another clock time.
    /// </summary>
    public static Clock operator -(Clock clock, Clock other) => new Clock (clock.Hours - other.Hours, clock.Minutes - other.Minutes);

    /// <summary>
    /// Increments th clock in one minute.
    /// </summary>
    public static Clock operator ++(Clock clock) => clock.Add(1);

    /// <summary>
    /// Decrement the clock in one minute.
    /// </summary>
    public static Clock operator --(Clock clock) => clock.Subtract(1);

    /// <summary>
    /// Adds a specified minutes amount to a clock
    /// </summary>
    public static Clock operator +(Clock clock, int minutes) => new Clock (clock.Hours, clock.Minutes + minutes);

    /// <summary>
    /// Subtract a specified minutes amount to a clock
    /// </summary>
    public static Clock operator -(Clock clock, int minutes) => new Clock (clock.Hours, clock.Minutes - minutes);

    /// <summary>
    /// multiplies the total amount of minutes by a specified factor.
    /// </summary>
    public static Clock operator *(Clock clock, int value) => new Clock (clock.ToMinute() * value);

    /// <summary>
    /// Divide the total amount of minutes by a specified factor.
    /// </summary>
    public static Clock operator /(Clock clock, int value) => new Clock(clock.ToMinute() / value);

    /// <summary>
    /// Compares the equality of a clock with any other object, including clocks.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator ==(Clock clock, Clock other) => clock.Equals(other);

    /// <summary>
    /// Compares the inequality of a clock with any other object, including clocks.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator !=(Clock clock, Clock other) => !clock.Equals(other);

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator >(Clock clock, Clock other) => clock.ToMinute() > other.ToMinute();

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator <(Clock clock, Clock other) => clock.ToMinute() < other.ToMinute();

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator >=(Clock clock, Clock other) => clock.ToMinute() >= other.ToMinute();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="clock"></param>
    /// <param name="other"></param>
    /// <returns></returns>
    public static bool operator <=(Clock clock, Clock other) => clock.ToMinute() <= other.ToMinute();
}

