using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class LedgerEntry
{
    public LedgerEntry(DateTime date, string desc, decimal chg)
    {
        Date = date;
        Desc = desc;
        Chg = chg;
    }

    public DateTime Date { get; }
    public string Desc { get; }
    public decimal Chg { get; }
}

public static class Ledger
{
    public static LedgerEntry CreateEntry(string date, string desc, int chng) => new LedgerEntry(DateTime.Parse(date, CultureInfo.InvariantCulture), desc, chng / 100.0m);

    private static CultureInfo CreateCulture(string cur, string loc)
    {
        if ((cur != "USD" && cur != "EUR") || (loc != "nl-NL" && loc != "en-US"))        
            throw new ArgumentException("Invalid currency");       

        var culture = new CultureInfo(loc);
        culture.NumberFormat.CurrencySymbol = cur == "USD" ? "$" : "€"; 
        culture.NumberFormat.CurrencyNegativePattern = loc != "en-US" ? 12 : 0; 
        culture.DateTimeFormat.ShortDatePattern = loc != "en-US" ? "dd/MM/yyyy" : "MM/dd/yyyy"; 
        return culture;
    }

    private static string PrintHead(string loc) => (loc == "en-US")
            ? "Date       | Description               | Change       " : loc == "nl-NL"
            ? "Datum      | Omschrijving              | Verandering  " : throw new ArgumentException("Invalid locale");

    private static string Description(string desc) => desc.Length > 25 ? $"{desc.Substring(0, 22)}..." : desc;

    private static string Change(IFormatProvider culture, decimal cgh) => cgh < 0.0m ? cgh.ToString("C", culture) : cgh.ToString("C", culture) + " ";

    private static string PrintEntry(IFormatProvider culture, LedgerEntry entry) =>
        $"{entry.Date.ToString("d", culture)} | {Description(entry.Desc),-25} | {Change(culture, entry.Chg),13}";

    private static IEnumerable<LedgerEntry> sort(LedgerEntry[] entries)
    {
        var result = new List<LedgerEntry>();
        result.AddRange(entries.Where(e => e.Chg < 0).OrderBy(x => $"{x.Date}@{x.Desc}@{x.Chg}"));
        result.AddRange(entries.Where(e => e.Chg >= 0).OrderBy(x => $"{x.Date}@{x.Desc}@{x.Chg}"));

        return result;
    }

    public static string Format(string currency, string locale, LedgerEntry[] entries)
    {
        string formatted = PrintHead(locale);
        var culture = CreateCulture(currency, locale);

        if (entries.Length > 0)
        {
            for (var i = 0; i < sort(entries).Count(); i++)
            {
                formatted += $"\n{PrintEntry(culture, sort(entries).Skip(i).First())}";
            }
        }

        return formatted;
    }
}
