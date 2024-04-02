using System;
    /* Write a C# program to manage a list of contacts. 
     * Define a class Contact with properties Name (string) and PhoneNumber(string).*/
class Contact {
    private string Name;
    private string PhoneNumber;

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public string getName() { 
        return Name;
    }
    public string getPhoneNumber()
    {
        return PhoneNumber;
    }
    public void setName(string name)
    {
        Name = name;
    }
    public void setPhoneNumber(string phoneNumber) 
    {
        PhoneNumber = phoneNumber;
    }

    public string toString()
    {
        string str = "Name: " + Name + "\nPhone Number: " + PhoneNumber;
        return str;
    }
}