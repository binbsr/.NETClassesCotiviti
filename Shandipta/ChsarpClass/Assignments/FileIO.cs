using System.IO;
using System;
using System.Collections.Generic;
 
namespace FileHandling
{
public class FileIO
    {/*
public DirectoryInfo CreateFolder(string path)
        {
var result=Directory.CreateDirectory(path);
return result;
        }
 
public void CreateFile(string path, string content="Hello World")
        {
File.WriteAllText(path, content);
        }
 
public void CreateFile(string path, string[] content)
        {
File.WriteAllLines(path, content);
        }

internal void CreateFileAnotherWay(string path, string fileContent)
        {
StreamWriter sw=new StreamWriter(path);
sw.WriteLine(fileContent);
sw.Flush();
sw.Close();
        }
 
internal void AppendTextUsingStreamWriter(string path, string textToAppend)
        {
StreamWriter sw=new StreamWriter(path, true);
sw.WriteLine(textToAppend);
sw.Flush();
sw.Close();
        }  


internal string[] ReadFile(string path)
        {
var fileContent=File.ReadAllText(path);
var lines=fileContent.Split("\n", System.StringSplitOptions.RemoveEmptyEntries);
return lines;
        }


 
// Nov20_Exercise
// Generate a text file (Physically) with content copied from The Aduenture of Black Peter. Read the file content in your program and print following to console:
 
internal  int NumberofCharacter(string path)
        {
int   results=0;
var fileContent=File.ReadAllText(path);
foreach(char c in fileContent)
            {
if (!char.IsWhiteSpace(c))
                {
results++;
                }
            }
return results;
        }
 
internal int NumberofWords(string path)
        {
int  results=0;
var fileContent=File.ReadAllText(path);
foreach(char c in fileContent)
            {
if (c.Equals(' ') ||c.Equals('\n'))
                {
results++;
                }
            }
return results;
        }

internal int NumberofSentence(string path)
        {
int results=0;
var fileContent=File.ReadAllText(path);
foreach(charcinfileContent)
            {
if (c.Equals('.') ||c.Equals('?'))
                {
results++;
                }
            }
returnresults;
        }
 
internalintNumberofVowels(stringpath)
        {
intresults=0;
varfileContent=File.ReadAllText(path);
stringvowels="aeiouAEIOU";
foreach(charcinfileContent)
            {
if (!char.IsWhiteSpace(c) &&vowels.IndexOf(c) >=0)
                {
results++;
                }
            }
returnresults;
        }
 
internalintNumberofSpecialCharacters(stringpath)
        {
intresults=0;
varfileContent=File.ReadAllText(path);
stringspecialCharacter="!@#$%^&*()_+";
foreach(charcinfileContent)
            {
if (!char.IsWhiteSpace(c) &&specialCharacter.IndexOf(c) >=0)
                {
results++;
                }
            }
returnresults;
        }
        */
    }
}

