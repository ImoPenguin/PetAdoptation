namespace PetAdoptation
{
    public partial class draftFrm : Form
    {
        public draftFrm()
        {
            InitializeComponent();

            label1.Text = Cart.chosenPet.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Black;
        }
    }
}