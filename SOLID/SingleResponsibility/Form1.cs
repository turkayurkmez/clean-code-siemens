using Microsoft.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();

            int affected = productService.CreateProduct(name, price);
            string message = affected > 0 ? "Kaydedildi" : "Kaydedilemedi";
            MessageBox.Show(message);
        }

        

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            changeBackroundColor();
        }

        private void changeBackroundColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
