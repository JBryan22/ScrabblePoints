using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Scrabbles
  {
    private  string _inputString;
    private static Dictionary<string, int> _pointValues = new Dictionary<string, int> {{"AEIOULNRST", 1}, {"DG", 2}, {"BCMP", 3}, {"FHVWY", 4},{"K", 5}, {"JX", 8},{"QZ", 10}};

    public Scrabbles (string inputString)
    {
     _inputString = inputString.ToUpper();
    }
    public int GetValue()
    {
        int totalValue = 0;
        for (int i = 0; i < _inputString.Length; i++)
       {
            foreach (KeyValuePair<string, int> entry in _pointValues)
            {
                if (entry.Key.Contains(_inputString[i].ToString()))
                {
                    totalValue += entry.Value;
                }
            }
       }
       return totalValue;
    }
  }
}