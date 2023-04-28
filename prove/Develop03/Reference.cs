class Reference {
    public string book;  // a public field that stores the book of the reference
    public int chapter;  // a public field that stores the chapter of the reference
    public int startVerse;  // a public field that stores the starting verse of the reference
    public int endVerse;  // a public field that stores the ending verse of the reference (if applicable)

    public Reference(string book, int chapter, int startVerse, int endVerse = 0) {
        // a constructor that takes in the book, chapter, startVerse and optional endVerse parameters
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse > 0 ? endVerse : startVerse;
    }

    public override string ToString() {
        if (startVerse == endVerse)  
        {
            return book + " " + chapter + ":" + startVerse;  // if the start and end verse are the same, return a string with the book, chapter, and startVerse fields formatted as "book chapter:startVerse"
        }
        else
        {
            return book + " " + chapter + ":" + startVerse + "-" + endVerse;  // if the start and end verse are different, return a string with the book, chapter, startVerse, and endVerse fields formatted as "book chapter:startVerse-endVerse"
        }
    }
}