using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// @author Michael Willams
/// Assignment 2
/// Main class for representing a customer
[Serializable]
public class Customer
{
    private int id;
	private string cusName;
    private string street;
    private string city;
    private string state;
    private string zip;

    public Customer(int id, string cusName, string street,
        string city, string state, string zip)
    {
        this.id = id;
        this.cusName = cusName;
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string CusName
    {
        get { return cusName; }
        set { cusName = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string Zip
    {
        get { return zip; }
        set { zip = value; }
    }

    public string ToString()
    {
        return "ID: " + this.id + 
            "<br />Customer Name: " + this.cusName + 
            "<br />Street: " +  this.street +
            "<br />City: " + this.city +
            "<br />State: " + this.state +
            "<br />Zip: " + this.zip;
    }
}