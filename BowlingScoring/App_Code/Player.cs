using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Player
{
    private string _name { get; set; }
    private int _score { get; set; }
    public string name 
    {
    get { return _name; }
    set { _name = value; }
    }
    public int score
    {
        get { return _score; }
        set { _score = value; }
    }
    private int _order { get; set; }
    public int order
    {
        get { return _order; }
        set { _order = value; }
    }
    public Player(string Name,int Order)
    {
        name = Name;
        order = Order;
    }
}