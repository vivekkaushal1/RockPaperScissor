using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RockPaperScissor
{
    [Activity(Label = "Rock|Paper|Scissor", MainLauncher = true, Icon = "@drawable/icon")]

    public class MainActivity : Activity
    {
        //int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            //RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            ImageButton btnRock = FindViewById<ImageButton>(Resource.Id.imageRock);
            btnRock.Click += BtnRock_Click;

            ImageButton btnPaper = FindViewById<ImageButton>(Resource.Id.imagePaper);
            btnPaper.Click += BtnPaper_Click;

            ImageButton btnScissor = FindViewById<ImageButton>(Resource.Id.imageScissor);
            btnScissor.Click += BtnScissor_Click;
        }

        public void BtnScissor_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string userSel = "scissor";
            mainGame(userSel);
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string userSel = "paper";
            mainGame(userSel);
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string userSel = "rock";
            mainGame(userSel);
        }

        void mainGame(string selcection)
        {
            
            Random rand = new Random();
            int AIsel = rand.Next(1, 4);

            TextView txtResult = FindViewById<TextView>(Resource.Id.textView4);
            ImageView AiSel = FindViewById<ImageView>(Resource.Id.AiImage);
            TextView txtAI = FindViewById<TextView>(Resource.Id.textView3);

            string userSel = selcection;

            if (AIsel == 1)
            {
                txtAI.Text = "AI selection is Rock";
                AiSel.SetImageResource(Resource.Drawable.rock);
            }
            else if (AIsel == 2)
            {
                txtAI.Text = "AI selection is Paper";
                AiSel.SetImageResource(Resource.Drawable.paper);
            }
            else
            {
                txtAI.Text = "AI selection is Scissor";
                AiSel.SetImageResource(Resource.Drawable.scissor);
            }

            switch (userSel)
            {
                case "rock":
                    if (AIsel != 2)
                    {
                        if (AIsel == 1)
                        {
                            txtResult.Text = "TIE";
                        }
                        else
                        {
                            txtResult.Text = ("YOU WIN");
                        }
                    }
                    else
                    {
                        txtResult.Text = ("AI WINS");
                    }
                    break;

                case "paper":
                    if (AIsel != 3)
                    {
                        if (AIsel == 2)
                        {
                            txtResult.Text = ("TIE");
                        }
                        else
                        {
                            txtResult.Text = ("You WIN");
                        }
                    }
                    else
                    {
                        txtResult.Text = ("AI WINS");
                    }
                    break;

                case "scissor":
                    if (AIsel != 1)
                    {
                        if (AIsel == 3)
                        {
                            txtResult.Text = ("TIE");
                        }
                        else
                        {
                            txtResult.Text = ("You WIN");
                        }
                    }
                    else
                    {
                        txtResult.Text = ("AI WINS");
                    }
                    break;

                default:
                    txtResult.Text = ("Invalid Selection..");
                    break;
            }
        }
    }
}

