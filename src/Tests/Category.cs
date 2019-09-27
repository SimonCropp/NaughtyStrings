using System.Collections.Generic;

class Category
{
    public string Title { get; }
    public string Description { get; }
    public List<string> Lines { get; }

    public Category(string title, string description, List<string> lines)
    {
        Title = title;
        Description = description;
        Lines = lines;
    }
}