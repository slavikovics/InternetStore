namespace InternetStore;

public class RandomAccessMemoryFilter
{
    public static void SortByPrice(List<RandomAccessMemory> randomAccessMemories)
    {
        foreach (RandomAccessMemory cpu in randomAccessMemories)
        {
            cpu.SortingParameters = RandomAccessMemorySortingParameters.Price;
        }
        
        randomAccessMemories.Sort();
    }
    
    public static void SortByMemorySize(List<RandomAccessMemory> randomAccessMemories)
    {
        foreach (RandomAccessMemory cpu in randomAccessMemories)
        {
            cpu.SortingParameters = RandomAccessMemorySortingParameters.MemorySize;
        }
        
        randomAccessMemories.Sort();
    }
}