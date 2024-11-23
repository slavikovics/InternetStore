namespace InternetStore;

public static class GraphicsCardsFilter
{
    public static void SortByPrice(List<GraphicsCard> graphicsCards)
    {
        foreach (GraphicsCard gpu in graphicsCards)
        {
            gpu.SortingParameters = GraphicsCardSortingParameters.Price;
        }
        
        graphicsCards.Sort();
    }
    
    public static void SortByVideoMemorySize(List<GraphicsCard> graphicsCards)
    {
        foreach (GraphicsCard gpu in graphicsCards)
        {
            gpu.SortingParameters = GraphicsCardSortingParameters.VideoMemorySize;
        }
        
        graphicsCards.Sort();
    }
}