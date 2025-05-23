public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        char[] separators = { ' ', ',', '.', '?', '¿', '!', '¡' };
        string[] wordsArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        _words = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    //Methods
    
    public Random _random = new Random();
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (isCompletelyHidden())
            {
                break;
            }

        }
        
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }

        }
        return true;
    }
    }