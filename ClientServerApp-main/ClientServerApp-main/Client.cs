using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientServerApp
{
    public class Client
    {
        public Client()
        {
        }
        public class validationDetails()
            {
            }

        public long ph_num { get; set; }
        public string name { get; set; }

    }
    public class contact_list
    {
        List<string> cli = new List<string>();
        string a = "Sai Kiran";
        string b = "Rajesh";
        string c = "Ravi Kishore";
        string d = "Nagu";
        public void list()
        {
            cli.Add(a);
            cli.Add(b);
            cli.Add(c);
            cli.Add(d);
        }
        public void group()
        {
            cli.Remove(a);

        }

    }
}

public class Options
{
    List<string> con = new List<string>();
    public void Add()
    {
        Console.WriteLine("Create new contact or add to existing contacts?");

        string n1 = Console.ReadLine();
        con.Add(n1);
        Console.WriteLine(con);
        Console.Read();


    }
    public void view()
    {
        Console.WriteLine("Displaying Message");
        Console.Read();

    }
    public void edit()
    {

    }
    public void delete()
    {

    }
}