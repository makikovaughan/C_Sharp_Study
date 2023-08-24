using System;

namespace DatingProfile
{
    class Profile
    {
        //Profile fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies = { };

        //Constructor
        public Profile(string name, int age, string city = "Unknown", string country = "Unknown", string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException("value", "You have to be over 18 years old.");
                }
                else
                {
                    age = value;
                }
            }
        }

        //Method 
        public string ViewProfile()
        {
            String user = $"Name: {name}\nAge: {age}\nCity: {city}, Country: {country}\nPronouns: {pronouns}";

            //Render if the hobbies is not empty
            if (this.hobbies.Length > 0)
            {
                user += "\nHobbies:\n";
                foreach (string hobby in this.hobbies)
                {
                    user += $"{hobby}\n";
                }
            }
            return user;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
