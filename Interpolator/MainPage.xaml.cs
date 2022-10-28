namespace Interpolator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

		private void clearRlc(object sender, EventArgs e)
		{
				RLC.Text = "";
		}

		private void OnInterpolateClicked(object sender, EventArgs e)
		{
				try
				{
            double rla = double.Parse(RLA.Text);
            double rlb = double.Parse(RLB.Text);
            double l = double.Parse(L.Text);
            double x = double.Parse(X.Text);

            double rlc = rla - (((rla - rlb) / l) * x);
						rlc = Math.Truncate(rlc * 1000) / 1000;
            RLC.Text = rlc.ToString();
        }
				catch(Exception Ex)
				{
            DisplayAlert("Alert", "Enter Valid Values", "OK");
        }
		}

}

