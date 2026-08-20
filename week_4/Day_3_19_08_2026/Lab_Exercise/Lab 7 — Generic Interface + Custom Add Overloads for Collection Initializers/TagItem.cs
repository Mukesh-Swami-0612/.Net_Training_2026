namespace Lab7;

// Represents a tag stored inside TagList.
public class TagItem
{
    // Stores the tag text.
    public string Tag { get; }

    // Indicates whether the tag is highlighted.
    public bool Highlighted { get; }

    // Creates a TagItem.
    public TagItem(string tag, bool highlighted)
    {
        Tag = tag;
        Highlighted = highlighted;
    }

    // Returns a readable representation of the tag.
    public override string ToString()
    {
        return Highlighted
            ? $"{Tag} [Highlighted]"
            : Tag;
    }
}