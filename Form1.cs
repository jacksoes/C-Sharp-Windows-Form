using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace homeword_9._21
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            import_to_listbox();
        }


        private void button_click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
            if (box_salestax.Text.Contains("%"))
            {
               box_salestax.Text = box_salestax.Text.Replace("%", "");
            }

            if (!(box_salestax.Text.Length == 0))
            {
                // run calculatiosn and return
                double sub_total = Double.Parse(box_labor.Text) + Double.Parse(box_material.Text);
                box_subtotal.Text = sub_total.ToString();

                double salesTax = sub_total * (double.Parse(box_salestax.Text) / 100);
                box_salestax.Text = string.Format("{0:0.00}", salesTax);

                double totalCost = sub_total + salesTax;
                box_totalcost.Text = string.Format("{0:0.00}", totalCost);   
            }

        }

        public void import_to_listbox()
        {
            string file_abbreviations = @"C:\vs_file-io\homework\abbreviations.txt";
            string[] abbreviations = File.ReadAllLines(file_abbreviations);
            string file_rates = @"C:\vs_file-io\homework\rates.txt";
            string[] rates = File.ReadAllLines(file_rates);
            for (int i = 0; i < abbreviations.Length; i++) listbox_states.Items.Add(abbreviations[i] + " : " + rates[i]);
        }
        private void listbox_states_SelectedIndexChanged(object sender, EventArgs e)
        {
            // return rate from selected string
            String selected = listbox_states.SelectedItem.ToString();
            selected = selected.Replace(".", "");
            String sales_tax_string = Regex.Match(selected, @"\d+").Value;

            //set it to sales tax return to box.
            double sales_tax = Double.Parse(sales_tax_string) / 100;
            box_salestax.Text = sales_tax.ToString() + "%";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void box_subtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}