using System;

namespace DatingProfile
{
    class Profile
    {
        //fileds
        private string name;

        private int age;

        private string city;

        private string country;

        private string pronouns;

        private string[] hobbies;

        //create a Profile constructor
        public Profile(
            string name,
            int age,
            //default values if infor not provided
            string city = "n/a",
            string country = "n/a",
            string pronouns = "they/them"
        )
        {
            //set the fields to the value passed in
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;

            //set hobbies to empty array of strings
            this.hobbies = new string[0];
        }

        //Methods
        public string ViewProfile()
        {
            //return type of string
            string bio = $"{name} {age} {city} {country} {pronouns}";

            if (this.hobbies.Length > 0)
            {
                //loop through hobbies array
                foreach (string hobby in hobbies)
                {
                    //add hobbies in the bio
                    bio += $" hobbies: {hobby} ";
                }
            }

            return bio;
        }

        //nothing return method with one parameter
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
