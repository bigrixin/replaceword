# Replace a word in a text file
Replaces a word in a text file with case-matching and automatic recognition of the first character.


## Not match case:  
  source str: name
  replace str: text
  source file content: My name is bigName
  result content: My text is is bigtext

## Match case:  
  source str: name
  replace str: text
  source file content: My name is bigName
  result content: My text is is bigName

## The first letter is automatically case replaced
  source str: name
  replace str: text
  source file content: My name is bigName
  result content: My text is is bigText
