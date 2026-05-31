public class PrefixTree {
    private HashSet<string> words = [];
    private HashSet<string> prefixs = [];
    
    public void Insert(string word) {
        for (int i = 1; i < word.Length; i++)
        {
            prefixs.Add(string.Join("", word.Take(i)));
        }
        prefixs.Add(word);
        words.Add(word);
    }
    
    public bool Search(string word)
        => words.Contains(word);
    
    public bool StartsWith(string prefix)
        => prefixs.Contains(prefix);
}
