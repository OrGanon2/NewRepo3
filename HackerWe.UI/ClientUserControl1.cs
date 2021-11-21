using HackerWe.Entities;
using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HackerWe.UI
{
   
    public partial class ClientUserControl1 : UserControl
    {
        Client Addclients = new Client();
        public event Action<Client> AddClient;


        public ClientUserControl1()
        {
            InitializeComponent();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var EmailCheck = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if(!EmailCheck.IsMatch(EmailText.Text)) { throw new EmailNotGoodExecption(); }
                Addclients.Id = int.Parse(TextId.Text);
                Addclients.IdentityNumber = IdentityNumberText.Text;
                Addclients.FirstName = FirstNameText.Text;
                Addclients.LastName = LastNameText.Text;
                Addclients.PhoneNumber = PhoneNumberText.Text;

                //Library.SaveBooksAsJSON();
                Library.Clients.Insert(0,Addclients);
                Library.SaveClientAsJSON();
                AddClient(Addclients);


                lblMessage.Text = "Added sucessesfully";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
