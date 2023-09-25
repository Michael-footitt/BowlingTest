using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public List<Player> Players = new List<Player>();
    public int counter = 1;
    
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    protected void btnAddPlayer_Click(object sender, EventArgs e) 
    {
        if (Page.IsValid)
        {
            Player newPlayer = new Player(txtName.Text, counter);
            Players.Add(newPlayer);
            lblPlayerAdded.Text = $"{newPlayer.name} was added to the game";
            txtName.Text = "";
            counter++;
            rfvName.Enabled = false;
            btnPlay_Click(sender, e);
        }
    }


    protected void btnPlay_Click(object sender, EventArgs e)
    {
        Session["Players"] = Players;
        Response.Redirect("Bowling.aspx");
    }
}