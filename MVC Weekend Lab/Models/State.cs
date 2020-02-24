using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Weekend_Lab.Models
{
    public class State
    {
        public string StateName { get; set; }

        public string StateAbbreviation { get; set; }

        public string StateCapital { get; set; }

        public string UserInput { get; set; }

        public State()
        {

        }

        public State(string stateName, string stateAbbreviation, string stateCapital)
        {
            StateName = stateName;
            StateAbbreviation = stateAbbreviation;
            StateCapital = stateCapital;

        }

        public static List<State> states = new List<State>
        {
            new State("Alabama" , "AL" , "Montgomery"),
            new State("Alaska" , "AK" , "Juneau"),
            new State("Arizona" , "AZ" , "Phoenix"),
            new State("Arkansas" , "AR" , "Little Rock"),
            new State("California" , "CA" , "Sacramento"),
            new State("Colorado" , "CO" , "Denver"),
            new State("Connecticut" , "CT" , "Hartford"),
            new State("Delaware" , "DE" , "Dover"),
            new State("Florida" , "FL" , "Tallahassee"),
            new State("Georgia" , "GA" , "Atlanta"),
            new State("Hawaii" , "HI" , "Honolulu"),
            new State("Idaho" , "ID" , "Boise"),
            new State("Illinois" , "IL" , "Springfield"),
            new State("Indiana" , "IN" , "Indianapolis"),
            new State("Iowa" , "IA" , "Des Moines"),
            new State("Kansas" , "KS" , "Topeka"),
            new State("Kentucky" , "KY" , "Frankfort"),
            new State("Louisiana" , "LA" , "Baton Rouge"),
            new State("Maine" , "ME" , "Augusta"),
            new State("Maryland" , "MD" , "Annapolis"),
            new State("Massachusetts" , "MA" , "Boston"),
            new State("Michigan" , "MI" , "Lansing"),
            new State("Minnesota" , "MN" , "Saint Paul"),
            new State("Mississippi" , "MS" , "Jackson"),
            new State("Missouri" , "MO" , "Jefferson City"),
            new State("Montana" , "MT" , "Helena"),
            new State("Nebraska" , "NE" , "Lincoln"),
            new State("Nevada" , "NV" , "Carson City"),
            new State("New Hampshire" , "NH" , "Concord"),
            new State("New Jersey" , "NJ" , "Trenton"),
            new State("New Mexico" , "NM" , "Santa Fe"),
            new State("New York" , "NY" , "Albany"),
            new State("North Carolina" , "NC" , "Raleigh"),
            new State("North Dakota" , "ND" , "Bismarck"),
            new State("Ohio" , "OH" , "Columbus"),
            new State("Oklahoma" , "OK" , "Oklahoma City"),
            new State("Oregon" , "OR" , "Salem"),
            new State("Pennsylvania" , "PA" , "Harrisburg"),
            new State("Rhode Island" , "RI" , "Providence"),
            new State("South Carolina" , "SC" , "Columbia"),
            new State("South Dakota" , "SD" , "Pierre"),
            new State("Tennessee" , "TN" , "Nashville"),
            new State("Texas" , "TX" , "Austin"),
            new State("Utah" , "UT" , "Salt Lake City"),
            new State("Vermont" , "VT" , "Montpelier"),
            new State("Virginia" , "VA" , "Richmond"),
            new State("Washington" , "WA" , "Olympia"),
            new State("West Virginia" , "WV" , "Charleston"),
            new State("Wisconsin" , "WI" , "Madison"),
            new State("Wyoming" , "WY" , "Cheyenne")
        };


        public string SearchForCapital()
        {
           
            string retVal = StateCapital;

            foreach(State state in states)
            {
                if(UserInput == state.StateName || UserInput == state.StateAbbreviation)
                {
                    retVal = state.StateCapital;

                    break;
                   
                }
                else
                {
                    retVal = "Wrong State Name or Abbreviation!";
                }
            }

            return retVal;
        }
    }
}
