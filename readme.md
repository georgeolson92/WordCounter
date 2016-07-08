## Plain English Specs
| Spec | Input | Output |
|:---  | :---  | :----  |
|User enters word, and a sentence in which to count instances of word| `"cats"; "Red cats, orange cats, brown cats, blue cats, purple cats"`| `"'Cats' appears 5 times."`|
|Only returns full matches| `"cat"; "I walked my cat to the cathedral."`| `"'Cat' appears 1 time."`|
|Ignore punctuation in inputted sentences | `"cat"; "I walked my cat, a purple cat, named Catherine, to the cathedral."`| `"'Cat' appears 2 times."`|
|Ignore capitalization in inputted sentences | `"cat"; "Cat behavior is always fascinating. I love cats."`| `"'Cat' appears 1 time."`|
