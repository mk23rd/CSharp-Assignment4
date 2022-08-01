using Gui_WinFormApp.NewFolder;
using System.Text.RegularExpressions;
namespace Gui_WinFormApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            do
            {
                if (!string.IsNullOrEmpty(txt_objectName.Text) && !string.IsNullOrEmpty(txt_count.Text)
                    && !string.IsNullOrEmpty(txt_number.Text) && !string.IsNullOrEmpty(txt_price.Text)
                    && !string.IsNullOrEmpty(txt_SKU.Text) && !string.IsNullOrEmpty(txt_PhonNo.Text))
                {
                    //try{
                        p.Count = Convert.ToInt32(txt_count.Text);
                    //}catch (Exception);
                    p.ItemName = txt_objectName.Text;
                    p.ItemNumber = txt_number.Text;
                    p.Date = dtp_datepicker1.Value;
                    p.Price = Convert.ToInt32(txt_price.Text);
                    p.Sku = txt_SKU.Text;
                    Regex r = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
                    if (r.IsMatch(txt_PhonNo.Text))
                    {
                        p.phoneNo = txt_PhonNo.Text;
                    }
                    p.save();
                    dgvShowProducts.DataSource = null;
                    dgvShowProducts.DataSource = Product.getAllProducts();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txt_objectName, "Name is required!");
                    //MessageBox.Show("Can't insert null values. Try again please");
                }
            }while(txt_count.Text == null || txt_objectName.Text == null || txt_number.Text == null ||
                    dtp_datepicker1.Text == null || txt_price.Text == null || txt_SKU.Text == null);
        }

        private void btn_add_MouseHover(object sender, EventArgs e)
        {
           //MessageBox.Show("Move the cursor Away!!");
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_number.Text = "";
            txt_count.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            txt_SKU.Text = "";

        }

        private void dgvShowProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_objectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_addItem_Click(object sender, EventArgs e)
        {

        }
    }
}