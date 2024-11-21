namespace GoldDigger;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private decimal GetRawGoldPrice()
    {
        try
        {
            return Convert.ToDecimal(rawDayPriceTxt.Text.Trim('.'));
        }
        catch (Exception)
        {
            MessageBox.Show("قیمت روز طلا به درستی وارد نشده");
            return 0;
        }
    }
    private decimal GetSellerPrice()
    {
        try
        {
            return Convert.ToDecimal(sellerPriceTxt.Text.Trim('.'));
        }
        catch (Exception)
        {
            MessageBox.Show("قیمت فروشنده به درستی وارد نشده");
            return 0;
        }
    }
    private decimal GetGoldWeigh()
    {
        try
        {
            return Convert.ToDecimal(goldWeightTxt.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("وزن طلا به درستی وارد نشده");
            return 0;
        }
    }
    private void calculateBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var rawGoldPrice = GetRawGoldPrice();
            var sellerPrice = GetSellerPrice();
            var goldWeight = GetGoldWeigh();

            if (rawGoldPrice > 0 && sellerPrice > 0 && goldWeight > 0)
            {
                var costOfGold = rawGoldPrice * goldWeight;
                if (costOfGold > sellerPrice)
                    MessageBox.Show("توجه نمایید ، قیمت فروش فروشنده کمتر از قیمت طلای خام شده است ، با دقت خرید نمایید.");
                var profit = sellerPrice - costOfGold;
                var profitPercentage = (profit / costOfGold) * 100;

                sellerProfitTxt.Text = Math.Round(profitPercentage).ToString();
                sellerProfitPriceTxt.Text = Math.Round(profit).ToString("N0");
            }
            else
            {
                sellerProfitTxt.Text = "0";
                sellerProfitPriceTxt.Text = "0";
            }
        }
        catch (Exception)
        {
            MessageBox.Show("خطا");
        }
    }
    private void rawDayPriceTxt_TextChanged(object sender, EventArgs e)
    {
        rawDayPriceTxt.TextChanged -= rawDayPriceTxt_TextChanged;
        var text = rawDayPriceTxt.Text.Replace(",", string.Empty);

        if (decimal.TryParse(text, out decimal value))
        {
            rawDayPriceTxt.Text = string.Format("{0:N0}", value);
            rawDayPriceTxt.SelectionStart = rawDayPriceTxt.Text.Length;
        }
        rawDayPriceTxt.TextChanged += rawDayPriceTxt_TextChanged;
    }
    private void sellerPriceTxt_TextChanged(object sender, EventArgs e)
    {
        sellerPriceTxt.TextChanged -= sellerPriceTxt_TextChanged;
        var text = sellerPriceTxt.Text.Replace(",", string.Empty);

        if (decimal.TryParse(text, out decimal value))
        {
            sellerPriceTxt.Text = string.Format("{0:N0}", value);
            sellerPriceTxt.SelectionStart = sellerPriceTxt.Text.Length;
        }
        sellerPriceTxt.TextChanged += sellerPriceTxt_TextChanged;
    }
}