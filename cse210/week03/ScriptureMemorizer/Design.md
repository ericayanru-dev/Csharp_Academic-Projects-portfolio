# Classes

## Word Class

### Responsibilities
<ul>
    private
    <li>_text: string</li>
    <li>_isHidden: bool</li> -> initialize as false
</ul>

### Behaviors
<ul>
    <li>HideWord(): string</li>
        {
           length = len(word)
           hiddenword = length * "_"

           return hiddenword
        }
    <li>GetIsHidden: bool</li>
        {
            return _ishidden;
        }
    <li>SetIsHidden: void<li>
        {
            _ishidden = true;
        }
</ul>

## Scripture

### Responsibilities
<ul>
    <li>_scripture: List<Word> </li>
    <li>_reference: Reference </li>
</ul>

### Behaviors
<ul>
    <li>Display(): void</li>
        print(scripture)

    <li>HideRandomWord(): void</li>
        scripture = list(text)

        scripture = [word1, qord2, asd, asda, asd, asdd]

        word = random(scripture) # return a random Word obj
        index = scripture.index(word)

        if word.GetIsHidden() != true:
            word.HideWord()
            word.SetIsHidden()
            scripture[index] = hiddenword 

        -> scripture = [word1, qord2, "___", asda, asd, asdd]

    <li></li>
</ul>