# Replace a word in a text file
Replaces a word in a text file with case-matching and automatic recognition of the first character.

  source str: name 
  
  replace str: text
  
  source file content: My name is bigName
  
#### Not match case:  
  
  result content: **My text is is bigtext**

#### Match case:  

  result content: **My text is is bigName**

#### The first letter is automatically case replaced

  result content: **My text is is bigText**
