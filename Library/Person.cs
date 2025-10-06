public class Person
{
        private string lirstName;
        private string lastName;

    public string FirstName
    {
        get { return lirstName; }
        set { lirstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Person()
    {
        FirstName = "";
        LastName = "";   
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }


}


    
    

