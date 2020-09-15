using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}

public class Tree : TreeBuildingRecord
{
    public List<Tree> Children { get; set; } = new List<Tree>();

    public Tree(TreeBuildingRecord record)
    {
        ParentId = record.ParentId;
        RecordId = record.RecordId;
    }

    public bool IsLeaf => Children.Count == 0;
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
        if (!(records?.Any() ?? false))                    throw new ArgumentException();               var orderedRecords = records.OrderBy(record => record.RecordId);        var hasInvalidItems = orderedRecords.Where((record, index) =>             record.RecordId != index ||            (record.RecordId == 0 && record.ParentId != 0) ||            (record.RecordId != 0 && record.ParentId >= record.RecordId)).Any();        if (hasInvalidItems)                   throw new ArgumentException();               var trees = orderedRecords.Select((record) => new Tree(record)).ToList();        trees.ForEach(item =>        {            if (item.RecordId > 0)                trees.First(record => record.RecordId == item.ParentId).Children.Add(item);        });

        return trees.First();
    }
}