public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What did you learn today?",
        "Describe a meaningful conversation you had today:",
        "What made you smile today?",
        "What would you like to do differently tomorrow?",
        "What was your favorite thing about the day?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}