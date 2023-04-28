using System;

class Word {
    public string text;  // define a public string property named "text"

    public Word(string text) { // define a constructor that accepts a string parameter named "text"
        this.text = text;  // assign the "text" parameter to the "text" property of the instance
    }

    public bool IsHidden() {  // define a public method named "IsHidden" that returns a boolean value
        return text.StartsWith("*");  // check if the "text" property starts with an asterisk character, and return true or false accordingly
    }

    public void Hide() {  // define a public method named "Hide" that doesn't return anything
        if (!IsHidden())  // check if the word is not already hidden
        {
            text = new string('*', text.Length);  // replace the "text" property with a string of asterisks of the same length as the original "text" string
        }
    }

    public override string ToString() {  // override the ToString method to return the "text" property of the instance
        return text;
    }
}