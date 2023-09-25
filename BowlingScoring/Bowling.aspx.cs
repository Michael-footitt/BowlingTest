using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Bowling : Page
{
    public List<Player> Players = new List<Player>();
    public int counter = 0;
    public int scoreForRound;
    public Game OnSharpTest;
    public int frame;
    public int pins;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OnSharpTest = new Game();
            Players = (List<Player>)Session["Players"];
            var firstPlayer = Players.ElementAt(0);
            lblName.Text = firstPlayer.name.ToString();
            OnSharpTest.player = firstPlayer.name;
            pins = 10;
            if (frame == 0)
            { frame = OnSharpTest.CurrentFrame; }
            lblFrame.Text = frame.ToString();
            
            List<Game> Games = new List<Game>();
            Games.Add(OnSharpTest);
            Session["Games"] = Games;
            
        }
    }

    protected void btnRoll_Click(object sender, EventArgs e) 
    {
        if (Session["Games"] != null)
        {
            var Games = (List<Game>)Session["Games"];
            OnSharpTest = Games.ElementAt(0);
        }
       
        if (frame == 0)
        { frame = OnSharpTest.CurrentFrame; }
        if (counter == 0 && pins == 0)
        { pins = 10; }
        if (Page.IsValid)
        {
            if (counter < 2 && pins > 0)
            {
                int score = Int32.Parse(txtScore.Text);
                OnSharpTest.Roll(score);
                pins = pins - score;
                counter++;

                switch (frame)
                {
                    case 1:
                        lblrd1.Text = OnSharpTest.Score().ToString();
                        break;
                    case 2:
                        lblrd2.Text = OnSharpTest.Score().ToString();
                        break;
                    case 3:
                        lblrd3.Text = OnSharpTest.Score().ToString();
                        break;
                    case 4:
                        lblrd4.Text = OnSharpTest.Score().ToString();
                        break;
                    case 5:
                        lblrd5.Text = OnSharpTest.Score().ToString();
                        break;
                    case 6:
                        lblrd6.Text = OnSharpTest.Score().ToString();
                        break;
                    case 7:
                        lblrd7.Text = OnSharpTest.Score().ToString();
                        break;
                    case 8:
                        lblrd8.Text = OnSharpTest.Score().ToString();
                        break;
                    case 9:
                        lblrd9.Text = OnSharpTest.Score().ToString();
                        break;
                    case 10:
                        lblrd10.Text = OnSharpTest.Score().ToString();
                        break;
                }
                if (pins == 0 || counter >= 2)
                {
                    //frame++;
                    //hfvframe.Value = frame.ToString();
                    counter = 0;
                    pins = 10;
                }
                if (frame == 11)
                {
                    lblrdTotal.Text = OnSharpTest.Score().ToString();
                    pnlGame.Visible = false;
                    pnlThankYou.Visible = true;
                }

            }
            else {
                switch (frame)
                {
                    case 1:
                        lblrd1.Text = OnSharpTest.Score().ToString();
                        break;
                    case 2:
                        lblrd2.Text = OnSharpTest.Score().ToString();
                        break;
                    case 3:
                        lblrd3.Text = OnSharpTest.Score().ToString();
                        break;
                    case 4:
                        lblrd4.Text = OnSharpTest.Score().ToString();
                        break;
                    case 5:
                        lblrd5.Text = OnSharpTest.Score().ToString();
                        break;
                    case 6:
                        lblrd6.Text = OnSharpTest.Score().ToString();
                        break;
                    case 7:
                        lblrd7.Text = OnSharpTest.Score().ToString();
                        break;
                    case 8:
                        lblrd8.Text = OnSharpTest.Score().ToString();
                        break;
                    case 9:
                        lblrd9.Text = OnSharpTest.Score().ToString();
                        break;
                    case 10:
                        lblrd10.Text = OnSharpTest.Score().ToString();
                        break;
                }
                //        frame++;
                //hfvframe.Value = frame.ToString();
                counter = 0;
                pins = 10;


            }
            List<Game> Games = new List<Game>();
            Games.Add(OnSharpTest);
            Session["Games"] = Games;
        }
    }

}