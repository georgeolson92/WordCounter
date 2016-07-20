# C&#35; Word Repeat Counter
#### By _George Olson_

### Description
_Count how many words are in a sentence with this program!_

### Specifications
| Behavior | Input | Output |
|:---  | :---  | :----  |
|enter word, and a string in which to count instances of word| `"cat"; "cat"`| `"'Cat' appears 1 time."`|
|count multiple instances of word| `"cats"; "Red cats orange cats brown cats blue cats purple cats"`| `"'Cats' appears 5 times."`|
|return 0 if no match| `"cat"; "dog" | `"Cat" appears 0 times.` |
|only return full word matches, not matching strings within words| `"cat"; "I walked my cat to the cathedral."`| `"'Cat' appears 1 time."`|
|ignore punctuation in inputted sentences| `"cat"; "I walked my cat, a purple cat, named Catherine, to the cathedral."`| `"'Cat' appears 2 times."`|
|ignore capitalization in inputted sentences| `"cat"; "Cat behavior is always fascinating. I love cats."`| `"'Cat' appears 1 time."`|

### Setup/Installation Requirements

**Windows Users:**
* Open PowerShell and ensure that C&#35; is installed (<a href="https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c">View link</a> for information on installing C&#35; in PowerShell)
* Ensure that Git project management is functioning (<a href="https://www.learnhowtoprogram.com/c/getting-started-with-c/git-project-setup-for-windows">View link</a> for information on setting up Git in PowerShell)
* Clone repository from github
* Change directory to project folder
* Enter "dnu restore" in PowerShell to restore dependences
* Enter "dnx kestrel" to compile code
* View "http://localhost:5004" in your default web browser

**Mac Users:**
* Please <a href="https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c">view link</a> for information on setting up your C&#35; environment on Mac.
* Open Terminal
* Clone repository from github
* Change directory to project folder
* Enter "dnu restore" in Terminal to restore dependences
* Enter "dnx kestrel" to compile code
* View "http://localhost:5004" in your default web browser

### Known Bugs
No known bugs in current version.

### Support and Contact Details
You can reach me via email: **georgeolson92@gmail.com**

### Technologies Used
C&#35;, Nancy framework, HTML, Bootstrap framework, ASP.NET

#### License
MIT

Copyright (c) 2016 **_(George Olson)_**
