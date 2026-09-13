using System;
using System.Data;
using BussnissLogicLayer;

public class Program
{
    static void testfind(int name)
    {
        clsCountries Country1 = clsCountries.Find(name);
        if (Country1 != null)
        {

            Console.WriteLine(Country1.CountryID);
            Console.WriteLine(Country1.CountryName);
            Console.WriteLine(Country1.Code);
            Console.WriteLine(Country1.PhoneCode);

        }

        else
        {
            Console.WriteLine("Country [" + name + "] not found!");
        }
    }

    static void TestAddNew()
    {
        clsCountries Country = new clsCountries();

        Country.CountryName = "Iraq";
        Country.Code = "964";
        if (Country.Save())
        {

            Console.WriteLine("contact added new with id = " + Country.CountryID);
            Console.WriteLine("contact added new with id = " + Country.Code);

        }
    }

    static void testUpdateCountry(int ID)
    {
        clsCountries contact1 = clsCountries.Find(ID);

        if (contact1 != null)
        {
            contact1.CountryName = "asd";
            contact1.Code = "12";
            contact1.PhoneCode = "+12";
        }

        if (contact1.Save())
        {

            Console.WriteLine("contact Updated with id = " + contact1.CountryID);

        }

    }

    static void testDeleteCountry(int ID)
    {
        if (clsCountries.IsCountryFound(ID))
        {
            if (clsCountries.DeleteCountry(ID))

                Console.WriteLine("Deleted Succssfuly");
            else
                Console.WriteLine("Deleted Dont Succssfuly");
        }
        else
        {
            Console.WriteLine("Deleted Dont Succssfuly cuz is not found");
        }
    }

    static void GetAllCountry()
    {
        DataTable dt = clsCountries.GetAllCountry();

        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"{row[0]} {row[1]} {row[2]}");

        }
    }

    static void IsCountryFound(string name)
    {
        if (clsCountries.IsCountryFound(name))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static void Main(string[] args)
    {
        //testfind(1);
       // TestAddNew();
      //  testUpdateCountry(1);
        //testDeleteCountry(7);
       // GetAllCountry();
        IsCountryFound("Canada");
    }
}

