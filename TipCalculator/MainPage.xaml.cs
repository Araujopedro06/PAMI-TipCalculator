namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SliderTipValue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tipporcentage.Text = Math.Round(SliderTipPercent.Value).ToString();
        }

        private void OnQuinzeBtn_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void OnVinteBtn_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void OnRounddownBtn_Clicked(object sender, EventArgs e)
        {
            // calcular a gorjeta, arredondando para baixo
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            // exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private void OnRoundupBtn_Clicked(object sender, EventArgs e)
        {
            // calcular a gorjeta, arredondando para cima
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            // exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private double CalculateTip()
        {
            
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            // calculo da gorjeta
            double result = amount * (percent / 100);
            return result;
        }

    }


}
