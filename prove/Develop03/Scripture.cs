class Scripture {
    public string book; // the book of the scripture
    public int chapter;  // the chapter number of the scripture
    public int startVerse; // the starting verse of the scripture
    public int endVerse; // the ending verse of the scripture (if any)
    public string text; // the text of the scripture
    public List<int> hiddenWords; // a list of indices of hidden words
    public int NumOfHiddenWords { get; set; } // the number of hidden words in the scripture

    public Scripture(string book, int chapter, int startVerse, string text) {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = startVerse; // if only one verse, endVerse equals startVerse
        this.text = text;
        this.hiddenWords = new List<int>(); // initialize the hiddenWords list to empty
        this.NumOfHiddenWords = 0; // initially, there are no hidden words
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text) {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
        this.text = text;
        this.hiddenWords = new List<int>(); // initialize the hiddenWords list to empty
        this.NumOfHiddenWords = 0; // initially, there are no hidden words
    }

    public string GetReference() {
        if (startVerse == endVerse) {
            return $"{book} {chapter}:{startVerse}";
        } else {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }

    public string GetText() {
        return text; // return the full text of the scripture
    }

    public bool IsAllWordsHidden() {
        return hiddenWords.Count == text.Split().Length; // check if all words in the scripture are hidden
    }
    public void ResetHiddenWords() {
    this.hiddenWords.Clear(); // clear the list of hidden words
    this.NumOfHiddenWords = 0; // reset the number of hidden words
}
}