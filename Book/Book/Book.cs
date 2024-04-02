using System;

class Book {
    /*Create a C# program that simulates a bookstore. 
     * Define a class Book with properties Title (string), Author (string), and Price (double).*/

    private String Title;
    private String Author;
    private double Price;

    public Book(String title, String author, double price)
    {
        Title = title; 
        Author = author; 
        Price = price;
    }

    public String getTitle()
    {
        return Title;
    }
    public String getAuthor()
    {
        return Author;
    }
    public double getPrice() {
        return Price;
    }

    public void setTitle(String title)
    {
        Title = title;
    }
    public void addAuthor(String author)
    {
        Author = author;
    }
    public void setPrice(double price) { 
        Price = price;
    }

    public String toString()
    {
        String str;
        str = "Title: " + Title + "\nAuthor: " + Author + "\nPrice: " + Price;
        return str;
    }
}
