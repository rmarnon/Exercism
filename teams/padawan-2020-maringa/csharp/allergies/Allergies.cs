using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public Allergen[] Allergens { get; set; }
    public int Mask { get; set; }

    public Allergies(int mask)
    {
        Mask = mask;
        if (Mask == 0)
        {
            Allergens = new Allergen[0];
        }
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if (Mask == 0)
            return false;

        List<int> list = new List<int>();
        int x = 0, exp = 0;

        while (x <= Mask)
        {
            x = (int)Math.Pow(2, exp);
            int value = (Mask & x);

            if (value == x)
            {
                list.Add(value);
            }
            exp++;
        }

        list.RemoveAll(x => x > 128);
        Allergens = new Allergen[list.Count];

        for (int i = 0; i < list.Count; i++)
        {
            Allergens[i] = Enum.Parse<Allergen>(list[i].ToString());
        }
        return Allergens.Contains(allergen);
    }

    public Allergen[] List()
    {
        var verify = Enum.Parse<Allergen>(Mask.ToString());
        IsAllergicTo(verify);
        return Allergens;
    }
}