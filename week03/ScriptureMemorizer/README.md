# Scripture Memorizer

A **C# console project** that helps memorize scriptures by hiding words step by step.  
Each time the user presses ENTER, more words are hidden until the full text is gone.

## Project Structure
- `Word.cs` – Represents a single word in the scripture (can be hidden or shown).
- `Reference.cs` – Stores the scripture reference (Book, Chapter, Verse(s)).
- `Scripture.cs` – Manages scripture text and randomly hides words.
- `Program.cs` – Main entry point where the program runs.

##  Features
- Randomly hides multiple words each turn.
- Displays scripture reference alongside the text.
- Stops when all words are hidden or user types `quit`.
- Exceeds requirements by hiding **3 words per step** instead of 1.

## Concepts Practiced
- Object-Oriented Programming (OOP)
- Classes & Encapsulation
- Randomization
- Collections (`List<T>`)
- String manipulation


