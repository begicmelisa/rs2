using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();

            _id = korisnikId;
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest()
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Telefon = txtTelefon.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                };
                if (!_id.HasValue)
                {
                    await _service.Insert<Model.Korisnici>(request);

                }
                else
                {
                    await _service.Update<Model.Korisnici>(_id.Value, request);
                }
                MessageBox.Show("Operacija uspjesna");
            }
        }

        private async void FrmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<Model.Korisnici>(_id);

                txtEmail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtTelefon.Text = korisnik.Telefon;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;

            }
        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void TxtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);

            }
        }
    }
}

