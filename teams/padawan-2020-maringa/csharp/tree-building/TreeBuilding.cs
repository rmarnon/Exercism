using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}

public class Tree
{
    public int Id { get; set; }
    public int ParentId { get; set; }

    public List<Tree> Children { get; set; }

    public bool IsLeaf => Children.Count == 0;
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
        records = records.OrderBy(p => p.RecordId).ToList();

        var trees = new List<Tree>();
        var previousRecordId = -1;

        foreach (var record in records)
        {
            var tree = new Tree { Children = new List<Tree>(), Id = record.RecordId, ParentId = record.ParentId };
            trees.Add(tree);
            VerifyTree(previousRecordId, tree);
            previousRecordId++;
        }

        if (trees.Count != 0)
        {
            foreach (var item in trees.Skip(1))
            {
                trees.FirstOrDefault(p => p.Id == item.ParentId).Children.Add(item);
            }
        }
        else
            throw new ArgumentException();

        return trees.First(t => t.Id == 0);       
    }

    private static void VerifyTree(int previousRecordId, Tree t)
    {
        if (t.Id == 0 && t.ParentId == 0)
        {
            return;
        }
        else 
        {
            if (t.ParentId < t.Id && t.Id == previousRecordId + 1)
            {
                return;
            }  
        }
        throw new ArgumentException();
    }
}