using Microsoft.AspNetCore.Mvc;

namespace backstage_recipe_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipeController : ControllerBase
{
    private readonly ILogger<RecipeController> _logger;

    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
    }

    public IEnumerable<Recipe> Get()
    {

        List<Recipe> recipeList = new List<Recipe>();
        recipeList.Add(new Recipe(){ Title="Cinnamon Rolls", Description="Nice and mushy rolls"});
        recipeList.Add(new Recipe(){ Title="Pizza the Hut", Description="Cheese and Spaceballs Pizza"});
        recipeList.Add(new Recipe(){ Title="Spaghette a la Code", Description="a messy Spagetthi"});

        return recipeList;
    }
}
