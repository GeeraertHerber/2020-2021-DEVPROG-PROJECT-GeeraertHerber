using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TinyProject.Models
{
    public class Character
    {
       
            public int char_id { get; set; }
            public string name { get; set; }
            public string birthday { get; set; }
            public List<string> occupation { get; set; }
            public string img { get; set; }
            public string status { get; set; }
            public string nickname { get; set; }
            public List<int> appearance { get; set; }
            public string portrayed { get; set; }
            public string category { get; set; }
            public List<int> better_call_saul_appearance { get; set; }
     
            public String AppearanceToString
            {
                get
                {
                    if (appearance.Count == 1)
                    {
                        return $"Season: {appearance[0]}";
                    }
                    String seasons = "Seasons: ";
                    foreach (int season in appearance)
                    {
                        seasons += $"{season},";
                    }
                    return seasons;

                }
            }
            public String OccupationToString 
            { get
                   {
                    if(occupation.Count == 1)
                    {
                        return $"Occupation: {occupation[0]} ";
                    }
                    String occupations = "Occupations:";
                    int counter = 0;
                    for(int i = 0; i < occupation.Count - 1; i++)
                    {
                        occupations += occupation[i];
                        counter += 1;
                    }
                    occupations += $" and {occupation[counter + 1]}";
                    return occupations;
                
                    }
            }
        }
    }

