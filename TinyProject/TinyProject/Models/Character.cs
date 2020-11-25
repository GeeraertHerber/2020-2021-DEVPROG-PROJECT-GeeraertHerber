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
                    return $"Appearces in season: {appearance[0]}";
                }
                String seasons = "Appearces in seasons: ";
                int count = 1;
                seasons += appearance[0];
                for(int i = 1; i < appearance.Count - 1; i++)
                {
                    seasons += $",{appearance[i]}";
                count += 1;
                }
                seasons += $" and {appearance[count]}";
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
                int counter = 1;
                occupations += occupation[0];
                for(int i = 1; i < occupation.Count - 1; i++)
                {
                    occupations += $", {occupation[i]}";
                    counter += 1;
                }
                Console.WriteLine(counter);
                occupations += $" and {occupation[counter]}";
                return occupations;
                
                }
            }
        }
    }

