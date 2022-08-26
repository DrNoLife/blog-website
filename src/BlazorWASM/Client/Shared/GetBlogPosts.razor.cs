using BlazorWASM.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWASM.Client.Shared;

public partial class GetBlogPosts
{
    [Parameter]
    public int PostsAmount { get; set; }

    [Parameter]
    public int PostsOffset { get; set; }

    private List<PostModel> _blogPosts;

    public GetBlogPosts()
    {
        _blogPosts = new();
    }

    protected override async Task OnInitializedAsync()
    {
        // Contact database.
        var dsa = "dsa";

        // Update list.

        StateHasChanged();
    }

    // When this component is loaded we need to do some things.
    // If we have a PostsAmount, then contact the database and retrieve that many posts.
    // If we have an offset as well, then add the offset to the query.

    // After that, throw the resulting data into a list.
    // Use that list to populate the html.
    // Make sure view is notified about the change.
}
