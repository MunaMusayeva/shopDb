using ConsoleApp22;

class proqram
{
    static async Task Main(string[] args)
    {
        shop dbContext = new();
        Category category = new Category()
        {
            Name = "Wirniyyat",
            Products = new List<product>()
            {
                new product()
                {
                     Name = "Milka",
                     Price = 10,
                },
                new product()
                {
                     Name = "Alpen Gold",
                     Price = 5,
                     
                },
                new product()
                {
                     Name = "Kinder",
                     Price = 7,
                     
                },
            }
        };
        await dbContext.categories.AddAsync(category);
        await dbContext.SaveChangesAsync();

    }
}
